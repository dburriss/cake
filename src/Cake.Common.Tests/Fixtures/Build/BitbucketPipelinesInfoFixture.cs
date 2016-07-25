﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using Cake.Common.Build.BitbucketPipelines.Data;
using Cake.Core;
using NSubstitute;

namespace Cake.Common.Tests.Fixtures.Build
{
    public class BitbucketPiplinesInfoFixture
    {
        public ICakeEnvironment Environment { get; set; }

        public BitbucketPiplinesInfoFixture()
        {
            Environment = Substitute.For<ICakeEnvironment>();

            // BitbucketPiplines RepositoryInfo
            Environment.GetEnvironmentVariable("BITBUCKET_COMMIT").Returns("4efbc1ffb993dfbcf024e6a9202865cc0b6d9c50");
            Environment.GetEnvironmentVariable("BITBUCKET_REPO_SLUG").Returns("cake");
            Environment.GetEnvironmentVariable("BITBUCKET_REPO_OWNER").Returns("cakebuild");
            Environment.GetEnvironmentVariable("BITBUCKET_BRANCH").Returns("develop");
            Environment.GetEnvironmentVariable("BITBUCKET_TAG").Returns("BitbucketPiplines");
        }

        public BitbucketPipelinesEnvironmentInfo CreateEnvironmentInfo()
        {
            return new BitbucketPipelinesEnvironmentInfo(Environment);
        }

        public BitbucketPipelinesRepositoryInfo CreateRepositoryInfo()
        {
            return new BitbucketPipelinesRepositoryInfo(Environment);
        }
    }
}
