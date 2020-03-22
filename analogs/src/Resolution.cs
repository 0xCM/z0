//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Analogs)]

namespace Z0.Parts
{        
    public sealed class Analogs : ApiResolution<Analogs, Analogs.C>
    {
        public Analogs() : base(AssemblyId.Analogs) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Analogs){ }}
    }
}