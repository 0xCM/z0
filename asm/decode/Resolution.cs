//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmDecoder)]

namespace Z0.Parts
{
    public sealed class AsmDecoder : ApiPart<AsmDecoder, AsmDecoder.C>
    {
        public class C : ApiCatalog<C> { public C() : base(PartId.AsmDecoder) {} }            
    }
}