//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmCore)]

namespace Z0.Parts
{
    public sealed class AsmCore : ApiResolution<AsmCore, AsmCore.C>
    {
        public AsmCore() : base(AssemblyId.AsmCore) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.AsmCore) { } }
    }
}