//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.RngCore)]

namespace Z0.Parts
{
    public sealed class RngCore : ApiPart<RngCore, RngCore.C>
    {        
        
        public class C : ApiCatalog<C> { public C() : base(PartId.RngCore) {} }            
    }
}