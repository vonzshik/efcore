﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class SpatialQueryInMemoryTest : SpatialQueryTestBase<SpatialQueryInMemoryFixture>
    {
        public SpatialQueryInMemoryTest(SpatialQueryInMemoryFixture fixture)
            : base(fixture)
        {
        }

        public override Task Intersects_equal_to_null(bool async)
            => Assert.ThrowsAsync<NullReferenceException>(() => base.Intersects_equal_to_null(async));

        public override Task Intersects_not_equal_to_null(bool async)
            => Assert.ThrowsAsync<NullReferenceException>(() => base.Intersects_not_equal_to_null(async));

        public override Task Distance_constant_lhs(bool async)
            => Task.CompletedTask;

        // Sequence contains no elements
        public override Task GetGeometryN_with_null_argument(bool async)
            => Task.CompletedTask;
    }
}
