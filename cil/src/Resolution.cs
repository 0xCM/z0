//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Cil)]

namespace Z0.Resolutions
{
    public sealed class Cil : AssemblyResolution<Cil, Cil.C>
    {
        public Cil() : base(AssemblyId.Cil) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Cil) {} }            
    }
}