//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmEncoder)]

namespace Z0.Parts
{
    public sealed class AsmEncoder : ApiPart<AsmEncoder, AsmEncoder.C>
    {        
        public class C : ApiCatalog<C> { public C() : base(PartId.AsmEncoder) {} }            
    }
}