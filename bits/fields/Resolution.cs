//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitFields)]

namespace Z0.Resolutions
{        
    public sealed class BitFields : ApiResolution<BitFields, BitFields.C>
    {
        public BitFields() : base(AssemblyId.BitFields) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.BitFields) {} }
    }
}