//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Intrinsics)]

namespace Z0.Resolutions
{
    public sealed class Intrinsics : ApiResolution<Intrinsics, Intrinsics.C>
    {        
        public Intrinsics() : base(AssemblyId.Intrinsics) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Intrinsics) { } }
    }
}