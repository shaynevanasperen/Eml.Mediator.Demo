﻿using Eml.Mediator.Contracts;
using Eml.Mediator.Tests.Common.Commands;
using Eml.Mediator.Tests.Common.Requests;
using Eml.Mediator.Tests.Common.Responses;
using Eml.Mediator.Tests.Integration.BaseClasses;
using Xunit;
using Shouldly;

namespace Eml.Mediator.Tests.Integration
{
    public class WhenExecutingTestEngines: IntegrationTestDiBase
    {

        [Fact]
        public void TestRequestEngine_ShouldBeDiscoverable()
        {
            var exported = classFactory.GetExport<IRequestEngine<TestRequest, TestResponse>>();

            exported.ShouldNotBeNull();
        }

        [Fact]
        public void TestRequestAsyncEngine_ShouldBeDiscoverable()
        {
            var exported = classFactory.GetExport<IRequestAsyncEngine<TestAsyncRequest, TestResponse>>();

            exported.ShouldNotBeNull();
        }

        [Fact]
        public void TestCommand_ShouldBeDiscoverable()
        {
            var exported = classFactory.GetExport<ICommandEngine<TestCommand>>();

            exported.ShouldNotBeNull();
        }

        [Fact]
        public void TestAsyncCommand_ShouldBeDiscoverable()
        {
            var exported = classFactory.GetExport<ICommandAsyncEngine<TestAsyncCommand>>();

            exported.ShouldNotBeNull();
        }
    }
}