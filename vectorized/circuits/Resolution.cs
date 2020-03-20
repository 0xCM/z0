//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Circuits)]

namespace Z0.Resolutions
{
    public sealed class Circuits : AssemblyResolution<Circuits, Circuits.C>
    {
        public Circuits() : base(AssemblyId.Circuits) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Circuits) {} }            
    }
}