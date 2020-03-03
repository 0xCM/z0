//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    public sealed class Fixed : AssemblyResolution<Fixed, Fixed.C>
    {
        const AssemblyId Identity = AssemblyId.Fixed;

        public Fixed() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }            
    }
}