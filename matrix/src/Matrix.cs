//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Matrix)]

namespace Z0.Parts
{
    public sealed class Matrix : ApiPart<Matrix, Matrix.C>
    {
        const PartId Identity = PartId.Matrix;
    
        public class C : ApiCatalog<C> { public C() : base(Identity) { } }
    }
}