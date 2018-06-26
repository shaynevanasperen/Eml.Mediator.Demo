﻿using System.Collections;
{
    internal class AllRequestsTestCases : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            return TypeExtensions.GetTestCaseEnumerator<TestRequest> (t => t.IsClosedTypeOf(typeof(IRequest<,>)) 
                                                         && !t.Name.Contains("TestRequestWithNoEngine") 
                                                         && !t.Name.EndsWith("WithMultipleEngine"));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}