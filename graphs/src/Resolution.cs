//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Graphs)]

namespace Z0.Resolutions
{
    public sealed class Graphs : AssemblyResolution<Graphs, Graphs.C>
    {
        public Graphs() : base(AssemblyId.Graphs) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Graphs) {} }
    }
}