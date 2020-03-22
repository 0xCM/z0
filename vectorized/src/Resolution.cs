//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Vectorized)]

namespace Z0.Parts
{
    public sealed class Vectorized : ApiPart<Vectorized, Vectorized.C>
    {
        public Vectorized() : base(PartId.Vectorized) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Vectorized) {} }    
    }   
}