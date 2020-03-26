//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Containers)]

namespace Z0.Parts
{
    public sealed class Containers : ApiPart<Containers, Containers.C>
    {        
        public class C : ApiCatalog<C> { public C() : base(PartId.Containers) {} }            
    }
}