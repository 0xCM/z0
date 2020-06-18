//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface INumericWidth<F> : INumericWidth, IFixedWidth<F>, ITypedLiteral<F,NumericWidth,uint>
        where F : struct, INumericWidth<F>
    {     
        NumericWidth INumericWidth.NumericWidth 
            => Widths.numeric<F>();               
    }
}