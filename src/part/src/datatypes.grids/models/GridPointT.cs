//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Locates a cell in a grid with <typeparamref name='T'/> parametric coordinates
    /// </summary>
    public readonly struct GridPoint<T> : IGridPoint<GridPoint<T>,T>
        where T : unmanaged
    {
        /// <summary>
        /// The cell row
        /// </summary>
        public T Row {get;}

        /// <summary>
        /// The cell column
        /// </summary>
        public T Col {get;}

        [MethodImpl(Inline)]
        public GridPoint(T row, T col)
        {
            Row = row;
            Col = col;
        }

        [MethodImpl(Inline)]
        public static implicit operator GridPoint<T>(Pair<T> src)
            => new GridPoint<T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator GridPoint<T>((T row, T col) src)
            => new GridPoint<T>(src.row, src.col);
    }
}