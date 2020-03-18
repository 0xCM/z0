//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitSpan)]

namespace Z0.Resolutions
{        
    public sealed class BitSpan : AssemblyResolution<BitSpan, BitSpan.C>
    {
        public BitSpan() : base(AssemblyId.BitSpan) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.BitSpan) { } }
    }
}