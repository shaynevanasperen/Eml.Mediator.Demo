﻿using System;
{
    public class WhenMakingAsyncRequestWithMultipleEngine : UnitTestBase
    {
        [Test]
        public async Task Response_ShouldThrowMultipleEngineException()
        {
            var request = new TestAsyncRequestWithMultipleEngine(Guid.NewGuid());

            await Should.ThrowAsync<MultipleEngineException>(async () => await mediator.GetAsync(request));
        }
    }
}