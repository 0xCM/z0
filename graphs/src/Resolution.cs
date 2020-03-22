//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Graphs)]

namespace Z0.Parts
{
    public sealed class Graphs : ApiResolution<Graphs, Graphs.C>
    {
        public Graphs() : base(AssemblyId.Graphs) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Graphs) {} }
    }
}