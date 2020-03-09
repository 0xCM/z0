//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.RngCore)]

namespace Z0.Resolutions
{
    public sealed class RngCore : AssemblyResolution<RngCore, RngCore.C>
    {
        public RngCore() : base(AssemblyId.RngCore) {}
        
        public class C : OpCatalog<C> { public C() : base(AssemblyId.RngCore) {} }            
    }
}