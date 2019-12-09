//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Defines a 64-bit grid
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid64<T>
        where T : unmanaged
    {                
        readonly ulong data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 8;

        readonly byte rows;

        readonly byte cols; 

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitGrid64<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bit operator ==(BitGrid64<T> gx, BitGrid64<T> gy)
            => gx.data == gy.data;

        [MethodImpl(Inline)]
        public static bit operator !=(BitGrid64<T> gx, BitGrid64<T> gy)
            => gx.data != gy.data;

        [MethodImpl(Inline)]
        public BitGrid64(ulong data, int rows, int cols)
        {
            this.data = data;
            this.rows = 0;
            this.cols = 0;
        }

        [MethodImpl(Inline)]
        internal BitGrid64(ulong data, GridDim dim)
        {
            this.data = data;
            this.rows = (byte)dim.RowCount;
            this.cols = (byte)dim.ColCount;
        }

        public ulong Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => rows;
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => cols;
        }

        public int CellCount
        {
            [MethodImpl(Inline)]
            get => ByteCount/size<T>();
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.AsBytes().As<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Cells);
        }

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Slices a sequence of bits
        /// </summary>
        public BitVector<T> this[int start, int count]
        {
            [MethodImpl(Inline)]
            get => BitGrid.slice(this,start,count);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<T> rhs)
            => data.Equals(rhs.data);

       [MethodImpl(Inline)]
        public BitGrid64<U> As<U>()
            where U : unmanaged
                => new BitGrid64<U>(data,rows,cols);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}