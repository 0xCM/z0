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
    /// Defines packed container for a grid over 256 bits for the dimenions
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid256<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        internal readonly Vector256<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static Dim<M,N> Dim => default;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = BitGrid256<T>.ByteCount;
        
        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = BitGrid256<T>.BitCount;

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => BitGrid256<T>.CellSize;

        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int CellCount => BitGrid256<T>.GridCells;

        [MethodImpl(Inline)]
        public static implicit operator Vector256<T>(in BitGrid256<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Block256<T>(in BitGrid256<M,N,T> src)
            => src.data.ToBlock();

        [MethodImpl(Inline)]
        public static implicit operator BitGrid256<M,N,T>(in Block256<T> src)
            => new BitGrid256<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid256<M,N,T>(in BitGrid256<T> src)
            => new BitGrid256<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid256<M,N,T>(Vector256<T> src)
            => new BitGrid256<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid256<T>(in BitGrid256<M,N,T> src)
            => new BitGrid256<T>(src.data);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> operator & (in BitGrid256<M,N,T> gx, in BitGrid256<M,N,T> gy)
            => BitGrid.and(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> operator | (in BitGrid256<M,N,T> gx, in BitGrid256<M,N,T> gy)
            => BitGrid.or(gx, gy);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> operator ^ (in BitGrid256<M,N,T> gx, in BitGrid256<M,N,T> gy)
            => BitGrid.xor(gx, gy);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> operator ~ (in BitGrid256<M,N,T> gx)
            => BitGrid.not(gx);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> operator - (in BitGrid256<M,N,T> gx)
            => BitGrid.negate(gx);

        [MethodImpl(Inline)]
        public static bit operator ==(in BitGrid256<M,N,T> g1, in BitGrid256<M,N,T> g2)
            => BitGrid.same(g1,g2);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitGrid256<M,N,T> g1, in BitGrid256<M,N,T> g2)
            => !BitGrid.same(g1,g2);
        
        [MethodImpl(Inline)]
        internal BitGrid256(Vector256<T> data)
            => this.data = data;
        
        [MethodImpl(Inline)]
        internal BitGrid256(in Block256<T> src)
            => this.data = src.TakeVector();
        
        public Vector256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
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
        public bool Equals(BitGrid256<M,N,T> rhs)
            =>  BitGrid.same(this,rhs);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}