//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Permute)]

namespace Z0.Parts
{
    public sealed class Permute : ApiPart<Permute, Permute.C>
    {
        public Permute() : base(PartId.Permute) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.Permute) {} }            
    }
}

namespace Z0
{
    using System;    

    [ApiHost("api")]
    public static partial class Permute
    {

    }

}