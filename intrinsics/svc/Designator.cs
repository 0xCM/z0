//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;
    using System.Collections.Generic;

    public sealed class IntrinsicsSvc : AssemblyResolution<IntrinsicsSvc, IntrinsicsSvc.C>
    {        
        const AssemblyId Identity = AssemblyId.IntrinsicsSvc;

        public IntrinsicsSvc() : base(AssemblyId.IntrinsicsSvc) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.IntrinsicsSvc) { } }
    }
}