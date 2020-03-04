//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;

    public sealed class DataBlocksTest : AssemblyResolution<DataBlocksTest>
    {
        public DataBlocksTest() : base(AssemblyId.BlocksTest) {}
    
        public override void Run(params string[] args) => App.Run(args);
    }
}