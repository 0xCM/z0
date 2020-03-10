//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.VBits)]

namespace Z0.Resolutions
{        
    public sealed class VBits : AssemblyResolution<VBits, VBits.C>
    {
        public VBits() : base (AssemblyId.VBits) {}

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.VBits) { } }
    }
}