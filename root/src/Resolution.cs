//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class Root : AssemblyResolution<Root, Root.C>
    {
        public const AssemblyId Identity = AssemblyId.Root;

        public Root() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }            
    }
}