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
    /// Defines a 16-bit grid sans dimensional content
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid16<T>
        where T : unmanaged
    {                
        readonly ushort data;        

        readonly byte rows;

        readonly byte cols;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 2;
        
        [MethodImpl(Inline)]
        public static implicit operator ushort(BitGrid16<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bit operator ==(BitGrid16<T> gx, BitGrid16<T> gy)
            => gx.data == gy.data;

        [MethodImpl(Inline)]
        public static bit operator !=(BitGrid16<T> gx, BitGrid16<T> gy)
            => gx.data != gy.data;

        [MethodImpl(Inline)]
        internal BitGrid16(ushort data, int rows, int cols)
        {
            this.data = data;
            this.rows = (byte)rows;
            this.cols = (byte)cols;
        }
        
        public ushort Data
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
            get => ByteCount * 8;
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
        /// Reads/writes an index-identified cell
        /// </summary>
        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, cell);
        }

        [MethodImpl(Inline)]
        public BitGrid16<U> As<U>()
            where U : unmanaged
                => new BitGrid16<U>(data,rows, cols);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid16<T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
 
    }
}