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
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct GridSpec<T>
        where T : unmanaged
    {
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly T RowCount;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly T ColCount;

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        public readonly T SegWidth;

        public readonly GridStorage Storage;

        [MethodImpl(Inline)]
        public GridSpec(T rows, T cols, T segwidth, int bytes, int bits, int segments)
        {
            RowCount = rows;
            ColCount = cols;
            SegWidth = segwidth;
            Storage = new GridStorage((uint)bits, (uint)segments);
        }

        [MethodImpl(Inline)]
        public bool Equals(GridSpec<T> rhs)
            => gmath.eq(RowCount,rhs.RowCount)
            && gmath.eq(ColCount,rhs.ColCount)
            && gmath.eq(SegWidth,rhs.SegWidth)
            && Storage.Equals(rhs.Storage);

        public override int GetHashCode()
            => HashCode.Combine(RowCount, ColCount, SegWidth, Storage);

        public override bool Equals(object rhs)
            => rhs is GridSpec<T> x && Equals(x);

        public string Format()
            => $"{RowCount}x{ColCount}x{SegWidth}";

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator ==(GridSpec<T> a, GridSpec<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridSpec<T> a, GridSpec<T> b)
            => !a.Equals(b);
    }
}