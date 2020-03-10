//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Containers)]

namespace Z0.Resolutions
{
    public sealed class Containers : AssemblyResolution<Containers, Containers.C>
    {
        public Containers() : base(AssemblyId.Containers) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Containers) {} }            
    }
}