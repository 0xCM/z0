//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    public sealed class TimeTest : AssemblyResolution<TimeTest>
    {
        public TimeTest() : base(AssemblyId.TimeTest) {}

        public override void Run(params string[] args) => App.Run(args);
    }
}