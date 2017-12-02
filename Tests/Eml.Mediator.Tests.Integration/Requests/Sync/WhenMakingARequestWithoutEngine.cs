﻿using System;
{
    public class WhenMakingARequestWithoutEngine : UnitTestBase
    {
        [Test]
        public void Response_ShouldThrowAMissingEngineException()
        {
            var request = new TestRequestWithNoEngine(Guid.NewGuid());

            Should.Throw<MissingEngineException>(() => mediator.Get(request));
        }
    }
}