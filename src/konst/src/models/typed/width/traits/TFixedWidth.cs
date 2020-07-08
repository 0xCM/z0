//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TFixedWidth<F> : IFixedWidth, TTypeWidth<F>, ITypedLiteral<F,FixedWidth,uint>
        where F : struct, TFixedWidth<F>
    {     
        FixedWidth IFixedWidth.FixedWidth 
            => Widths.tfixed<F>();               
    }
}