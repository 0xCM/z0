//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    public sealed class BitCore : AssemblyResolution<BitCore>
    {
        public BitCore() : base(AssemblyId.BitCore) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.BitCore) {} }
    }
}