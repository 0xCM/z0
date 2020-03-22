//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.LibM)]

namespace Z0.Parts
{        
    public sealed class LibM : ApiPart<LibM, LibM.C>
    {
        public LibM() : base(PartId.LibM) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.LibM) { } }
    }
}