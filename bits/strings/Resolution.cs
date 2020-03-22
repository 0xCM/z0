//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitString)]

namespace Z0.Parts
{
    public sealed class BitString : ApiPart<BitString, BitString.C>
    {
        public BitString() : base(PartId.BitString) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.BitString) {} }            
    }
}