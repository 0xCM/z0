//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Circuits)]

namespace Z0.Parts
{
    public sealed class Circuits : ApiPart<Circuits, Circuits.C>
    {        
        public class C : ApiCatalog<C> { public C() : base(PartId.Circuits) {} }            
    }
}