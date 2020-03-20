//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.VSvc)]

namespace Z0.Resolutions
{
    public sealed class VSvc : AssemblyResolution<VSvc, VSvc.C>
    {        
        public VSvc() : base(AssemblyId.VSvc) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.VSvc) { } }
    }
}