//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class Blocks : AssemblyResolution<Blocks, Blocks.C>
    {
        public Blocks() : base(AssemblyId.Blocks) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Blocks){ }}
    }
}