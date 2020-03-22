//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitCore)]

namespace Z0.Parts
{        
    public sealed class BitCore : ApiPart<BitCore, BitCore.C>
    {
        public BitCore() : base(PartId.BitCore) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.BitCore) {} }
    }
}