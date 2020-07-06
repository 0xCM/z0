//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface TNumericWidth<F> : INumericWidth<F>
        where F : struct, TNumericWidth<F>
    {     
        NumericWidth INumericWidth.NumericWidth 
            => Widths.numeric<F>();               
    }
}