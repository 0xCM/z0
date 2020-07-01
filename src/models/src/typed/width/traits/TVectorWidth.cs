//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TVectorWidth<F> : IVectorWidth, TFixedWidth<F>, ITypedLiteral<F,VectorWidth,uint>
        where F : struct, TVectorWidth<F>
    {     
        VectorWidth IVectorWidth.VectorWidth 
            => Widths.vector<F>();               
    }
}