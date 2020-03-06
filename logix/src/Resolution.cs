//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class Logix : AssemblyResolution<Logix, Logix.C>
    {
        const AssemblyId Identity = AssemblyId.Logix;

        public Logix() : base(AssemblyId.Logix) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Logix) { } }
    }
}