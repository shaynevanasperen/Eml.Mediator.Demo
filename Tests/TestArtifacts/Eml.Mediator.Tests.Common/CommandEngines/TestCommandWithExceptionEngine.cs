﻿using System.ComponentModel.Composition;
using Eml.Mediator.Contracts;
using Eml.Mediator.Tests.Common.Commands;

namespace Eml.Mediator.Tests.Common.CommandEngines
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TestCommandWithExceptionEngine : ICommandEngine<TestCommandWithException>
    {
        public void Set(TestCommandWithException command)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}