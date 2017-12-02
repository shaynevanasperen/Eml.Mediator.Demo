﻿using System;
{
    public class AllRequests
    {
        [Test]
        [TestCaseSource(typeof(AllRequestsTestCases))]
        public void MustHaveExactlyOneEngine(Type requestType)
        {
            var typeArguments = requestType
                .GetInterfaces()
                .Single(i => i.IsClosedTypeOf(typeof(IRequest<,>)))
                .GetGenericArguments();

            var engineInterfaceType = typeof(IRequestEngine<,>).MakeGenericType(typeArguments);

            var engineTypes = AppDomain.CurrentDomain.GetAssemblies()
                                        .SelectMany(a => a.DefinedTypes)
                                        .Where(t => engineInterfaceType.IsAssignableFrom(t))
                                        .ToArray();

            engineTypes.Length.ShouldBe(1);
        }

        [Test]
        [TestCaseSource(typeof(AllRequestsTestCases))]
        public void MustHaveACorrespondingEngine(Type requestType)
        {
            var typeArguments = requestType
                .GetInterfaces()
                .Single(i => i.IsClosedTypeOf(typeof(IRequest<,>)))
                .GetGenericArguments();

            var engineInterfaceType = typeof(IRequestEngine<,>).MakeGenericType(typeArguments);

            var engineType = AppDomain.CurrentDomain
                                       .GetAssemblies()
                                       .SelectMany(a => a.DefinedTypes)
                                       .Single(t => engineInterfaceType.IsAssignableFrom(t));

            engineType.Name.ShouldBe(requestType.Name + "Engine");
        }
    }
}