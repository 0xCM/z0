//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class Fixed : AssemblyResolution<Fixed, Fixed.C>
    {
        public Fixed() : base(AssemblyId.Fixed) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Fixed) { } }            
    }
}