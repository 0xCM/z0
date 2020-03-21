//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Asm)]

namespace Z0.Resolutions
{
    public sealed class Asm : ApiResolution<Asm,Asm.C>
    {
        public Asm() : base(AssemblyId.Asm) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Asm) { } }            
    }
}