//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class Blocks : AssemblyResolution<Blocks, Blocks.C>
    {
        const AssemblyId Identity = AssemblyId.Blocks;

        public Blocks() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity){ }}
    }
}