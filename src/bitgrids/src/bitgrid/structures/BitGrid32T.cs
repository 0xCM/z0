//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed; 
    using static Memories;

    /// <summary>
    /// Defines a 32-bit grid
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=8)]
    [IdentityProvider(typeof(BitGridIdentity))]
    public readonly ref struct BitGrid32<T>
        where T : unmanaged
    {                
        internal readonly uint Data;       

        readonly byte rows;

        readonly byte cols; 

        readonly ushort align;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 4;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitGrid32<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static bit operator ==(BitGrid32<T> gx, BitGrid32<T> gy)
            => gx.Data == gy.Data;

        [MethodImpl(Inline)]
        public static bit operator !=(BitGrid32<T> gx, BitGrid32<T> gy)
            => gx.Data != gy.Data;

        [MethodImpl(Inline)]
        internal BitGrid32(uint data, GridDim dim)
        {
            this.Data = data;
            this.rows = (byte)dim.RowCount;
            this.cols = (byte)dim.ColCount;
            this.align = 0;
        }

        [MethodImpl(Inline)]
        internal BitGrid32(uint data, int rows, int cols)
        {
            this.Data = data;
            this.rows = (byte)rows;
            this.cols = (byte)cols;
            this.align = 0;
        }

        public uint Content
        {
            [MethodImpl(Inline)]
            get => Data;
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
            get => Data.AsBytes().As<T>();
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
        public BitVector<T> this[byte start, byte count]
        {
            [MethodImpl(Inline)]
            get => BitGrid.slice(this,start,count);
        }

        [MethodImpl(Inline)]
        public BitGrid32<U> As<U>()
            where U : unmanaged
                => new BitGrid32<U>(Data,rows,cols);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid32<T> rhs)
            => Data.Equals(rhs.Data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
 
    }
}