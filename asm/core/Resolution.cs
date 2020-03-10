//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmCore)]

namespace Z0.Resolutions
{
    public sealed class AsmCore : AssemblyResolution<AsmCore, AsmCore.C>
    {
        public AsmCore() : base(AssemblyId.AsmCore) {}

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.AsmCore) { } }
    }
}