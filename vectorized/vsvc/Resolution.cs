//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.VSvc)]

namespace Z0.Parts
{
    public sealed class VSvc : ApiResolution<VSvc, VSvc.C>
    {        
        public VSvc() : base(AssemblyId.VSvc) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.VSvc) { } }
    }
}