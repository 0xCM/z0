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
    /// A grid of natural dimensions M and N such that M*N = 64
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid64<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly BitGrid64<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = BitGrid64<T>.ByteCount;
        
        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = BitGrid64<T>.BitCount;

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => BitGrid64<T>.CellSize;

        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int GridCells => BitGrid64<T>.GridCells;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<M,N,T>(in Block64<T> src)
            => new BitGrid64<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<M,N,T>(ulong src)
            => new BitGrid64<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitGrid64<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<T>(BitGrid64<M,N,T> src)
            => new BitGrid64<T>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<M,N,T>(BitGrid64<T> src)
            => new BitGrid64<M,N,T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitGrid64<M,N,T> g1, BitGrid64<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(BitGrid64<M,N,T> g1, BitGrid64<M,N,T> g2)
            => !g1.Equals(g2);

        [MethodImpl(Inline)]
        internal BitGrid64(ulong src)
            => this.data = src;
        
        [MethodImpl(Inline)]
        internal BitGrid64(Block64<T> src)
            => this.data = src.As<ulong>().Head;

        public ulong Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The number of allocated cells
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => data.CellCount;
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => BitCount;
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount => natval<M>();         

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount => natval<N>();  

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.Cells;
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref data[cell];
        }

        [MethodImpl(Inline)]
        public BitGrid64<U> As<U>()
            where U : unmanaged
                => data.As<U>();
        
        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}