//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes the memory layout of a 2-d grid
    /// </summary>
    public readonly struct GridSpec
    {
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly ushort RowCount;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly ushort ColCount;

        /// <summary>
        /// The number of bits in a storage cell
        /// </summary>
        public readonly ushort CellWidth;

        /// <summary>
        /// The the toal number of allocated storage cells
        /// </summary>
        public readonly uint CellCount;

        /// <summary>
        /// The the toal number of segment-aligned bits allocated for storage
        /// </summary>
        public readonly uint StoreWidth;

        /// <summary>
        /// The the toal number of segment-aligned bytes allocated for storage
        /// </summary>
        public readonly uint StoreSize;

        [MethodImpl(Inline)]
        public static bool operator ==(GridSpec a, GridSpec b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridSpec a, GridSpec b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public GridSpec(ushort rows, ushort cols, ushort wCell, uint zStore, uint wStore, uint cells)
        {
            RowCount = rows;
            ColCount = cols;
            CellWidth = wCell;
            StoreSize = zStore;
            StoreWidth = wStore;
            CellCount = cells;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridSpec rhs)
            => RowCount == rhs.RowCount && ColCount == rhs.ColCount
            && CellWidth == rhs.CellWidth && StoreWidth == rhs.StoreWidth
            && StoreSize == rhs.StoreSize;

        public override int GetHashCode()
            => HashCode.Combine(RowCount, ColCount, CellWidth, StoreWidth, CellCount);

        public override bool Equals(object rhs)
            => rhs is GridSpec x && Equals(x);

        public string Format()
            => $"{RowCount}x{ColCount}x{CellWidth}";

        public override string ToString()
            => Format();
    }
}