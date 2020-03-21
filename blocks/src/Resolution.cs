//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Blocks)]

namespace Z0.Resolutions
{        
    public sealed class Blocks : ApiResolution<Blocks, Blocks.C>
    {
        public Blocks() : base(AssemblyId.Blocks) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Blocks){ }}
    }
}