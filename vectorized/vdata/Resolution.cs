//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.VData)]

namespace Z0.Resolutions
{
    public sealed class VData : AssemblyResolution<VData, VData.C>
    {
        public VData() : base(AssemblyId.VData) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.VData, DataResourceIndex.Create(Z0.Data.Resources)) {} }            
    }
}