//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.MathSvc)]

namespace Z0.Resolutions
{
    public sealed class MathServices : AssemblyResolution<MathServices, MathServices.C>
    {        
        public const string SvcCollectionName = "math.services";                

        public MathServices() : base(AssemblyId.MathSvc) {}

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.MathSvc) {} }    
    }
}