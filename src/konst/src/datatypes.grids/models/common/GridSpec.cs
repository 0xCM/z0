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
    /// Characterizes the memory layout of a 2-d grid
    /// </summary>
    [StructLayout(LayoutKind.Sequential), Datatype]
    public readonly struct GridSpec : IDataType<GridSpec>
    {
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public ushort RowCount {get;}

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public ushort ColCount {get;}

        /// <summary>
        /// The number of bits in a storage cell
        /// </summary>
        public ushort CellWidth {get;}

        /// <summary>
        /// The the total number of allocated storage cells
        /// </summary>
        public uint CellCount {get;}

        /// <summary>
        /// The the total number of segment-aligned bits allocated for storage
        /// </summary>
        public uint StoreWidth {get;}

        /// <summary>
        /// The the total number of segment-aligned bytes allocated for storage
        /// </summary>
        public uint StoreSize {get;}

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