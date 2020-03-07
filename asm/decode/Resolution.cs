//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class AsmDecoder : AssemblyResolution<AsmDecoder, AsmDecoder.C>
    {
        public AsmDecoder() : base(AssemblyId.AsmDecoder) {}
        

        public class C : OpCatalog<C> { public C() : base(AssemblyId.AsmDecoder) {} }            
    }
}