﻿using System;
{
    public class AllEngines
    {
        [Test]
        [TestCaseSource(typeof(AllExportsTestCases))]
        public void ShouldHaveNonSharedAttribute(Type exportedType)
        {
            var partCreationPolicyAttribute = exportedType
                .GetCustomAttributes(typeof(PartCreationPolicyAttribute), true)
                .FirstOrDefault();

            partCreationPolicyAttribute.ShouldNotBeNull();

            var creationPolicyAttribute = partCreationPolicyAttribute as PartCreationPolicyAttribute;
            creationPolicyAttribute?.CreationPolicy.ShouldBe(CreationPolicy.NonShared);
        }
    }
}