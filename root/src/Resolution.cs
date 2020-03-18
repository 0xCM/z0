//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Root)]

namespace Z0.Resolutions
{        
    public sealed class Root : AssemblyResolution<Root, Root.C>
    {
        public Root() : base(AssemblyId.Root) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Root) { } }            
    }
}