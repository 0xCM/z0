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
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentity))]
    public readonly ref struct BitGrid32<T>
        where T : unmanaged
    {                
        readonly uint data;       

        readonly byte rows;

        readonly byte cols; 

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 4;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitGrid32<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bit operator ==(BitGrid32<T> gx, BitGrid32<T> gy)
            => gx.data == gy.data;

        [MethodImpl(Inline)]
        public static bit operator !=(BitGrid32<T> gx, BitGrid32<T> gy)
            => gx.data != gy.data;

        [MethodImpl(Inline)]
        internal BitGrid32(uint data, GridDim dim)
        {
            this.data = data;
            this.rows = (byte)dim.RowCount;
            this.cols = (byte)dim.ColCount;
        }

        [MethodImpl(Inline)]
        internal BitGrid32(uint data, int rows, int cols)
        {
            this.data = data;
            this.rows = (byte)rows;
            this.cols = (byte)cols;
        }

        public uint Data
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
        public BitVector<T> this[byte start, byte count]
        {
            [MethodImpl(Inline)]
            get => BitGrid.slice(this,start,count);
        }

        [MethodImpl(Inline)]
        public BitGrid32<U> As<U>()
            where U : unmanaged
                => new BitGrid32<U>(data,rows,cols);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid32<T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
 
    }
}