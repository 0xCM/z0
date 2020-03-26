//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.GenericNumerics)]

namespace Z0.Parts
{
    public sealed class GenericNumerics : ApiPart<GenericNumerics, GenericNumerics.C>
    {        
        public class C : ApiCatalog<C> { public C() : base(PartId.GenericNumerics) {} }    
    }
}