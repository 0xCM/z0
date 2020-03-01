//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class DataBlocksTest : AssemblyResolution<DataBlocksTest>
    {
        public DataBlocksTest() : base(AssemblyId.DataBlocksTest) {}
    
        public override void Run(params string[] args) => App.Run(args);
    }
}