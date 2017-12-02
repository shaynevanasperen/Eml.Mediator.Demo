﻿using System.Collections;
{
    internal class AllAsyncCommandsTestCases : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            return TypeExtensions.GetTestCaseEnumerator<TestAsyncCommand>(t => t.IsAssignableTo<ICommandAsync>()
                                                                               && !t.Name.Contains("TestAsyncCommandWithNoEngine")
                                                                               && !t.Name.EndsWith("TestAsyncCommandWithMultipleEngine"));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}