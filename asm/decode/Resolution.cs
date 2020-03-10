//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmDecoder)]

namespace Z0.Resolutions
{
    public sealed class AsmDecoder : AssemblyResolution<AsmDecoder, AsmDecoder.C>
    {
        public AsmDecoder() : base(AssemblyId.AsmDecoder) {}
        

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.AsmDecoder) {} }            
    }
}