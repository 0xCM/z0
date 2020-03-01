//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    public sealed class RootTest : AssemblyResolution<RootTest>
    {
        public RootTest() : base(AssemblyId.RootTest) {}

        public override void Run(params string[] args) => App.Run(args);
    }
}