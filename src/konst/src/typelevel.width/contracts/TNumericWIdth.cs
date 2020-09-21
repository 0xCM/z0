//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TNumericWidth<W> : INumericWidth<W>
        where W : struct, TNumericWidth<W>
    {
        NumericWidth INumericWidth.NumericWidth
            => Widths.numeric<W>();

        TypeWidth ITypeWidth.TypeWidth
            => Widths.type<W>();
    }
}