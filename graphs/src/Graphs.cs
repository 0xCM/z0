//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Graphs)]

namespace Z0.Parts
{
    public sealed class Graphs : ApiPart<Graphs, Graphs.C>
    {
        public Graphs() : base(PartId.Graphs) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.Graphs) {} }
    }
}