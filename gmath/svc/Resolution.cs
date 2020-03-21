//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.MathSvc)]

namespace Z0.Resolutions
{
    public sealed class MathServices : ApiResolution<MathServices, MathServices.C>
    {        
        public const string SvcCollectionName = "math.services";                

        public MathServices() : base(AssemblyId.MathSvc) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.MathSvc) {} }    
    }
}