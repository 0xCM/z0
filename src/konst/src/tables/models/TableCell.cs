//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Identifies a cell within the context of a table
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct TableCell : IDataTypeComparable<TableCell>
    {
        /// <summary>
        /// A zero-based row index
        /// </summary>
        public uint Row {get;}

        /// <summary>
        /// A zero-based columnt index
        /// </summary>
        public uint Col {get;}

        [MethodImpl(Inline)]
        public TableCell(uint row, uint col)
        {
            Row = row;
            Col = col;
        }

        [MethodImpl(Inline)]
        public static implicit operator TableCell((uint row, uint col) src)
            => new TableCell(src.row, src.col);

        public string Format()
            => string.Format("({0},{1})", Row, Col);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)alg.hash.calc(Row,Col);

        public bool Equals(TableCell src)
            => Row == src.Row && Col == src.Col;

        public override bool Equals(object src)
            => src is TableCell x && Equals(src);

        [MethodImpl(Inline)]
        public int CompareTo(TableCell src)
        {
            if(Row == src.Row)
                return Col.CompareTo(src.Col);
            else
                return Row.CompareTo(src.Row);
        }

        [MethodImpl(Inline)]
        public static bool operator ==(TableCell a, TableCell b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(TableCell a, TableCell b)
            => a.Equals(b);

        public static TableCell Zero => default;

        public static TableCell Empty
            => new TableCell(uint.MaxValue, uint.MaxValue);
    }
}