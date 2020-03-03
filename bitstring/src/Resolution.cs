//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class BitString : AssemblyResolution<BitString, BitString.C>
    {
        public BitString() : base(AssemblyId.BitString) {}
        
        public class C : OpCatalog<C> { public C() : base(AssemblyId.BitString) {} }            
    }
}