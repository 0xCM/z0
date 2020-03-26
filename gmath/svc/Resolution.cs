//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MathSvc)]

namespace Z0.Parts
{
    public sealed class MathServices : ApiPart<MathServices, MathServices.C>
    {        
        public const string SvcCollectionName = "math.services";                

        public class C : ApiCatalog<C> { public C() : base(PartId.MathSvc) {} }    
    }
}