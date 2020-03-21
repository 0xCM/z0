//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Logix)]

namespace Z0.Resolutions
{        
    public sealed class Logix : ApiResolution<Logix, Logix.C>
    {
        public Logix() : base(AssemblyId.Logix) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Logix) { } }
    }
}