//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitString)]

namespace Z0.Resolutions
{
    public sealed class BitString : AssemblyResolution<BitString, BitString.C>
    {
        public BitString() : base(AssemblyId.BitString) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.BitString) {} }            
    }
}