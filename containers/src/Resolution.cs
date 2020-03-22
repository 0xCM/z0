//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Containers)]

namespace Z0.Parts
{
    public sealed class Containers : ApiResolution<Containers, Containers.C>
    {
        public Containers() : base(AssemblyId.Containers) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Containers) {} }            
    }
}