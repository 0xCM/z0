//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitPack)]

namespace Z0.Resolutions
{        
    public sealed class BitPack : AssemblyResolution<BitPack, BitPack.C>
    {
        public BitPack() : base (AssemblyId.BitPack) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.BitPack) { } }
    }
}