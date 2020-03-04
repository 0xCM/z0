//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class GMathSvc : AssemblyResolution<GMathSvc, GMathSvc.C>
    {        
        public GMathSvc() : base(AssemblyId.GMathSvc) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.GMathSvc) {} }    
    }
}