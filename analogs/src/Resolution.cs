//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Analogs)]

namespace Z0.Resolutions
{        
    public sealed class Analogs : AssemblyResolution<Analogs, Analogs.C>
    {
        public Analogs() : base(AssemblyId.Analogs) {}

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Analogs){ }}
    }
}