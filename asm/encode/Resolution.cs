//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmEncoder)]

namespace Z0.Resolutions
{
    public sealed class AsmEncoder : AssemblyResolution<AsmEncoder, AsmEncoder.C>
    {
        public AsmEncoder() : base(AssemblyId.AsmEncoder) {}
        

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.AsmEncoder) {} }            
    }
}