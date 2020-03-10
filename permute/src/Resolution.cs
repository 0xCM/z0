//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Permute)]

namespace Z0.Resolutions
{
    public sealed class Permute : AssemblyResolution<Permute, Permute.C>
    {
        public Permute() : base(AssemblyId.Permute) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Permute) {} }            
    }
}