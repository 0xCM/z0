//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;
    using System.Collections.Generic;

    public sealed class Intrinsics : AssemblyResolution<Intrinsics, Intrinsics.C>
    {        
        const AssemblyId Identity = AssemblyId.Intrinsics;

        public Intrinsics() : base(AssemblyId.Intrinsics) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Intrinsics) { } }
    }
}