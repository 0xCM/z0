//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class Cil : AssemblyResolution<Cil, Cil.C>
    {
        public Cil() : base(AssemblyId.Cil) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Cil) {} }            
    }
}