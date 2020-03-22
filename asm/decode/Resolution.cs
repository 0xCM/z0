//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmDecoder)]

namespace Z0.Parts
{
    public sealed class AsmDecoder : ApiResolution<AsmDecoder, AsmDecoder.C>
    {
        public AsmDecoder() : base(AssemblyId.AsmDecoder) {}
        

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.AsmDecoder) {} }            
    }
}