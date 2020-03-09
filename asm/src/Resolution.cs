//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Asm)]

namespace Z0.Resolutions
{
    public sealed class Asm : AssemblyResolution<Asm,Asm.C>
    {
        public Asm() : base(AssemblyId.Asm) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Asm) { } }            
    }
}