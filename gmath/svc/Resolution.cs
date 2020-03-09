//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class MathServices : AssemblyResolution<MathServices, MathServices.C>
    {        
        public const string SvcCollectionName = "math.services";                

        public MathServices() : base(AssemblyId.MathSvc) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.MathSvc) {} }    
    }
}