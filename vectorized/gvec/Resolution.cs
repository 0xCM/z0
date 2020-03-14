//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.GVec)]

namespace Z0.Resolutions
{
    public sealed class GVec : AssemblyResolution<GVec, GVec.C>
    {
        public GVec() : base(AssemblyId.GVec) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.GVec) {} }            
    }
}