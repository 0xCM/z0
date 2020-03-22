//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.LibM)]

namespace Z0.Parts
{        
    public sealed class LibM : ApiResolution<LibM, LibM.C>
    {
        public LibM() : base(AssemblyId.LibM) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.LibM) { } }
    }
}