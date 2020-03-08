//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class Graphs : AssemblyResolution<Graphs, Graphs.C>
    {
        public Graphs() : base(AssemblyId.Graphs) {}
        
        public class C : OpCatalog<C> { public C() : base(AssemblyId.Graphs) {} }
    }
}