//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmCore)]

namespace Z0.Parts
{
    public sealed class AsmCore : ApiPart<AsmCore, AsmCore.C>
    {
        public class C : ApiCatalog<C> { public C() : base(PartId.AsmCore) { } }
    }
}