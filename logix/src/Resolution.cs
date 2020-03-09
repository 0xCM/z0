//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Logix)]

namespace Z0.Resolutions
{        
    public sealed class Logix : AssemblyResolution<Logix, Logix.C>
    {
        public Logix() : base(AssemblyId.Logix) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Logix) { } }
    }
}