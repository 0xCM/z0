//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Polyrand)]

namespace Z0.Resolutions
{
    public sealed class Polyrand : AssemblyResolution<Polyrand, Polyrand.C>
    {
        public Polyrand() : base(AssemblyId.Polyrand) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Polyrand) {} }            
    }
}