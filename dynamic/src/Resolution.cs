//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Dynamic)]

namespace Z0.Resolutions
{
    public sealed class Dynamic : ApiResolution<Dynamic, Dynamic.C>
    {
        public Dynamic() : base(AssemblyId.Dynamic) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Dynamic) { } }               
    }
}