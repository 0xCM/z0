//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.IntrinsicsSvc)]

namespace Z0.Resolutions
{
    public sealed class IntrinsicsSvc : AssemblyResolution<IntrinsicsSvc, IntrinsicsSvc.C>
    {        
        public IntrinsicsSvc() : base(AssemblyId.IntrinsicsSvc) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.IntrinsicsSvc) { } }
    }
}