//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Fixed)]

namespace Z0.Parts
{        
    public sealed class Fixed : ApiResolution<Fixed, Fixed.C>
    {
        public Fixed() : base(AssemblyId.Fixed) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Fixed) { } }            
    }
}