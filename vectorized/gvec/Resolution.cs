//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.GVec)]

namespace Z0.Parts
{
    public sealed class GVec : ApiResolution<GVec, GVec.C>
    {
        public GVec() : base(AssemblyId.GVec) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.GVec) {} }            
    }
}