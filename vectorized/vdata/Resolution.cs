//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VData)]

namespace Z0.Parts
{
    public sealed class VData : ApiPart<VData, VData.C>
    {
        public VData() : base(PartId.VData) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.VData, ByteSourceIndex.Create(Z0.Data.Resources)) {} }            
    }
}