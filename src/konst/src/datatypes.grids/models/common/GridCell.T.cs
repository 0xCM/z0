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
    /// Defines the coordinates of a cell in a 2-dimensionsl <typeparamref name='T'/> grid
    /// </summary>
     public readonly struct GridCell<T>
     {
        public uint Row {get;}

        public uint Col {get;}

        [MethodImpl(Inline)]
        public GridCell(uint row, uint col)
        {
            Row = row;
            Col = col;
        }

        [MethodImpl(Inline)]
        public static implicit operator GridCell<T>(in GridCell<T,uint> src)
            => new GridCell<T>(src.Row, src.Col);

        [MethodImpl(Inline)]
        public static implicit operator GridCell<T>(in GridCell<T,uint,uint> src)
            => new GridCell<T>(src.Row, src.Col);
    }
}