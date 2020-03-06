//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class Root : AssemblyResolution<Root, Root.C>
    {
        public Root() : base(AssemblyId.Root) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Root) { } }            
    }
}