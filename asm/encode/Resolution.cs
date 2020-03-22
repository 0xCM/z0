//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmEncoder)]

namespace Z0.Parts
{
    public sealed class AsmEncoder : ApiResolution<AsmEncoder, AsmEncoder.C>
    {
        public AsmEncoder() : base(AssemblyId.AsmEncoder) {}
        

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.AsmEncoder) {} }            
    }
}