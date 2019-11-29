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
    /// Defines a 64-bit grid sans dimensional content
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

        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = ByteCount * 8;
        
        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int GridCells => ByteCount/size<T>();

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => bitsize<T>();

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<T>(ulong src)
            => new BitGrid64<T>(src);

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
        internal BitGrid64(ulong data)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitGrid64(Block64<T>  src)
            => this.data = src.As<ulong>().Head;

        public ulong Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public int CellCount
        {
            [MethodImpl(Inline)]
            get => GridCells;
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => BitCount;
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
        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.Add(ref Head, cell);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<T> rhs)
            => data.Equals(rhs.data);

        [MethodImpl(Inline)]
        public BitGrid64<U> As<U>()
            where U : unmanaged
                => data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}