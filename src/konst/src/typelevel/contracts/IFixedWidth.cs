//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFixedWidth<F> : ICellWidth, WType<F>, ITypedLiteral<F,CellWidth,uint>
        where F : struct, IFixedWidth<F>
    {
        CellWidth ICellWidth.CellWidth
            => Widths.cell<F>();
    }
}