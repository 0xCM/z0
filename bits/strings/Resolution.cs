//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitString)]

namespace Z0.Resolutions
{
    public sealed class BitString : ApiResolution<BitString, BitString.C>
    {
        public BitString() : base(AssemblyId.BitString) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.BitString) {} }            
    }
}