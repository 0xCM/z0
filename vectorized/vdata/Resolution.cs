//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.VData)]

namespace Z0.Parts
{
    public sealed class VData : ApiResolution<VData, VData.C>
    {
        public VData() : base(AssemblyId.VData) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.VData, DataResourceIndex.Create(Z0.Data.Resources)) {} }            
    }
}