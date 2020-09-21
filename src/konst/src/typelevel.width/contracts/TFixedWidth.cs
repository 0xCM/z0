//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TFixedWidth<F> : ICellWidth, TTypeWidth<F>, ITypedLiteral<F,CellWidth,uint>
        where F : struct, TFixedWidth<F>
    {
        CellWidth ICellWidth.CellWidth
            => Widths.cell<F>();
    }
}