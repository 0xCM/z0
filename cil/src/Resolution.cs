//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Cil)]

namespace Z0.Parts
{
    public sealed class Cil : ApiResolution<Cil, Cil.C>
    {
        public Cil() : base(AssemblyId.Cil) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Cil) {} }            
    }
}