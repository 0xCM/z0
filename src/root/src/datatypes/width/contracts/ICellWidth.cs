//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICellWidth : ITypeWidth
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguation
        /// </summary>
        CellWidth CellWidth
            => (CellWidth)BitWidth;

   }

    public interface ICellWidth<W> : ICellWidth
        where W : unmanaged, ICellWidth<W>
    {

    }
}