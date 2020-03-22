//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Root)]

namespace Z0.Parts
{        
    public sealed class Root : ApiResolution<Root, Root.C>
    {
        public Root() : base(AssemblyId.Root) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Root) { } }            
    }
}