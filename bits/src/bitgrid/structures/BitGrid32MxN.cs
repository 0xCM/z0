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
    /// A grid of natural dimensions M and N such that M*N = 32
    /// </summary>
    /// <remarks>
    ///  Conforming dimensions include 1x32, 32x1, 2x16, 16x2, 4x8, and 8x4.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid32<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly BitGrid32<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dimension => default;        

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = BitGrid32<T>.ByteCount;
        
        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = BitGrid32<T>.BitCount;

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => BitGrid32<T>.CellSize;

        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int GridCells => BitGrid32<T>.GridCells;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<M,N,T>(uint src)
            => new BitGrid32<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(BitGrid32<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<T>(BitGrid32<M,N,T> src)
            => new BitGrid32<T>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<M,N,T>(in Block32<T> src)
            => new BitGrid32<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<M,N,T>(BitGrid32<T> src)
            => new BitGrid32<M,N,T>(src.Data);

        [MethodImpl(Inline)]
        public static bool operator ==(BitGrid32<M,N,T> g1, BitGrid32<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(BitGrid32<M,N,T> g1, BitGrid32<M,N,T> g2)
            => !g1.Equals(g2);

        [MethodImpl(Inline)]
        internal BitGrid32(uint src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal BitGrid32(Block32<T> src)
            => this.data = src.As<uint>().Head;

        public uint Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

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

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.Cells;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public int RowCount => natval<M>();         

        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public int ColCount => natval<N>();  

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref data[cell];
        }

        /// <summary>
        /// The characterizing grid moniker
        /// </summary>
        public readonly GridMoniker<T> Moniker
            => GridMoniker.FromDim<T>(RowCount, ColCount);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid32<M,N,T> rhs)
            => data.Equals(rhs.data);

       public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}