//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class VFuncs : AssemblyResolution<VFuncs, VFuncs.C>
    {
        const AssemblyId Identity = AssemblyId.VFuncs;

        public VFuncs() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) {} }    
    }   
}