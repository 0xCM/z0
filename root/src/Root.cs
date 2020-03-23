//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Root)]

namespace Z0.Parts
{        
    public sealed class Root : ApiPart<Root, Root.C>
    {
        public class C : ApiCatalog<C> { public C() : base(PartId.Root) { } }            
    }
}