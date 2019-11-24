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
        public static Dim<M,N> Dim => default;

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
        public static int CellCount => BitGrid64<T>.CellCount;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<M,N,T>(Block64<T> src)
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

        public ulong Scalar
        {
            [MethodImpl(Inline)]
            get => data.Scalar;
        }

        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public int RowCount => natval<M>();         

        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public int ColCount => natval<N>();  

        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}