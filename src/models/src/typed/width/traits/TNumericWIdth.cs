//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TNumericWidth<F> : INumericWidth, TFixedWidth<F>, ITypedLiteral<F,NumericWidth,uint>
        where F : struct, TNumericWidth<F>
    {     
        NumericWidth INumericWidth.NumericWidth 
            => Widths.numeric<F>();               
    }
}