//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    /// <summary>
    /// Locates a cell within a grid
    /// </summary>
     [StructLayout(LayoutKind.Sequential), Datatype]
     public readonly struct GridCell : IDataTypeEquatable<GridCell>
     {
        /// <summary>
        /// The cell row
        /// </summary>
        public uint Row {get;}

        /// <summary>
        /// The cell column
        /// </summary>
        public uint Col {get;}

        [MethodImpl(Inline)]
        public GridCell(uint row, uint col)
        {
            Row = row;
            Col = col;
        }

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Row,Col);
        }

        [MethodImpl(Inline)]
        public bool Equals(GridCell src)
            => Row == src.Row && Col == src.Col;

        public override int GetHashCode()
            => (int)Hashed;

        public override bool Equals(object src)
            => src is GridCell x && Equals(x);

        public string Format()
            => $"({Row},{Col})";


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator GridCell((uint row, uint col) src)
            => new GridCell(src.row,src.col);

        [MethodImpl(Inline)]
        public static implicit operator (uint row, uint col)(GridCell src)
            => (src.Row, src.Col);
    }
}