//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class Asm : AssemblyResolution<Asm,Asm.C>
    {
        const AssemblyId Identity = AssemblyId.Asm;        

        public Asm() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }            
    }
}