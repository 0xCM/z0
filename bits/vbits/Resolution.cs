//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.VBits)]

namespace Z0.Resolutions
{        
    public sealed class VBits : ApiResolution<VBits, VBits.C>
    {
        public VBits() : base (AssemblyId.VBits) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.VBits) { } }
    }
}