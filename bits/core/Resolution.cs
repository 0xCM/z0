//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitCore)]

namespace Z0.Resolutions
{        
    public sealed class BitCore : AssemblyResolution<BitCore, BitCore.C>
    {
        public BitCore() : base(AssemblyId.BitCore) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.BitCore) {} }
    }
}