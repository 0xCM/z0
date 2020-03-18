//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.DVec)]

namespace Z0.Resolutions
{
    public sealed class DVec : AssemblyResolution<DVec, DVec.C>
    {
        public DVec() : base(AssemblyId.DVec) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.DVec) {} }            
    }
}