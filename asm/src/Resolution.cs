//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Asm)]

namespace Z0.Parts
{
    public sealed class Asm : ApiPart<Asm,Asm.C>
    {
        public Asm() : base(PartId.Asm) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Asm) { } }            
    }
}