//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IVectorWidth<F> : IVectorWidth, IFixedWidth<F>, ITypedLiteral<F,VectorWidth,uint>
        where F : struct, IVectorWidth<F>
    {
        VectorWidth IVectorWidth.VectorWidth
            => Widths.vector<F>();
    }
}