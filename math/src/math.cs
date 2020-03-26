//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

[assembly: PartId(PartId.Math)]

namespace Z0.Parts
{
    public sealed class Math : ApiPart<Math, Math.C>
    {
        public Math() : base(PartId.Math) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.Math) {} }            
    }
}

namespace Z0
{    

}