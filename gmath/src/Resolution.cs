//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.GenericNumerics)]

namespace Z0.Resolutions
{
    public sealed class GMath : AssemblyResolution<GMath, GMath.C>
    {        
        public GMath() : base(AssemblyId.GenericNumerics) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.GenericNumerics) {} }    
    }
}