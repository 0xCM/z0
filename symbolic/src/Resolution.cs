//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Symbolic)]

namespace Z0.Resolutions
{
    public sealed class Symbolic : AssemblyResolution<Symbolic, Symbolic.C>
    {
        public Symbolic() : base(AssemblyId.Symbolic) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Symbolic) {} }            
    }
}