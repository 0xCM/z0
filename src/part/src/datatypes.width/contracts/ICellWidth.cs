//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICellWidth : ITypeWidth//, ITypedLiteral<CellWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguation
        /// </summary>
        CellWidth CellWidth
            => (CellWidth)BitWidth;

        // CellWidth ITypedLiteral<CellWidth>.Class
        //     => CellWidth;

        // uint ITypedLiteral<CellWidth,uint>.Value
        //     => BitWidth;

        // string ITypedLiteral<CellWidth>.Name
        //     => CellWidth.FormatName();
    }

    public interface ICellWidth<W> : ICellWidth
        where W : unmanaged, ICellWidth<W>
    {

    }
}