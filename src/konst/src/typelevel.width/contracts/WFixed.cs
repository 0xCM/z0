//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface WFixed<F> : ICellWidth, WType<F>, ITypedLiteral<F,CellWidth,uint>
        where F : struct, WFixed<F>
    {
        CellWidth ICellWidth.CellWidth
            => Widths.cell<F>();
    }
}