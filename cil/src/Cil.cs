//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Cil)]

namespace Z0.Parts
{
    public sealed class Cil : ApiPart<Cil, Cil.C>
    {        
        public class C : ApiCatalog<C> { public C() : base(PartId.Cil) {} }            
    }
}