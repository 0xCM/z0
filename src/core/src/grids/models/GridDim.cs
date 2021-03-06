//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static CharText;

    /// <summary>
    /// Defines grid dimensions based on specification without parametrization
    /// </summary>
    [StructLayout(LayoutKind.Sequential), DataType]
    public readonly struct GridDim : IDataTypeEquatable<GridDim>
    {
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public uint RowCount {get;}

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public uint ColCount {get;}

        [MethodImpl(Inline)]
        public GridDim(uint rows, uint cols)
        {
            RowCount = rows;
            ColCount = cols;
        }

        /// <summary>
        /// Formats the dimension in canonical form
        /// </summary>
        public string Format()
            => $"{RowCount}x{ColCount}";

        [MethodImpl(Inline)]
        public void Deconstruct(out uint rows, out uint cols)
        {
            rows = RowCount;
            cols = ColCount;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridDim src)
            => src.RowCount == RowCount
            && src.ColCount == ColCount;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)FastHash.combine(RowCount, ColCount);

        public override bool Equals(object obj)
            => obj is GridDim d && Equals(d);

        public static bool operator ==(GridDim d1, GridDim d2)
            => d1.Equals(d2);

        public static bool operator !=(GridDim d1, GridDim d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public static implicit operator GridDim((int rows, int cols) src)
            => new GridDim((uint)src.rows,(uint)src.cols);

        [MethodImpl(Inline)]
        public static implicit operator GridDim((uint rows, uint cols) src)
            => new GridDim(src.rows,src.cols);

        public static GridDim Empty
            => default;

        public static RenderTemplate RT =>
             fLT + nameof(GridDim.RowCount) + RT + x +
             fLT + nameof(GridDim.ColCount) + RT;
    }
}