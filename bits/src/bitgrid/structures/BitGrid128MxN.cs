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
    /// A grid of natural dimensions M and N such that M*N = 128
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid128<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly Vector128<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static Dim<M,N> Dim => default;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = BitGrid128<T>.ByteCount;
        
        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = BitGrid128<T>.BitCount;

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => BitGrid128<T>.CellSize;

        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int CellCount => BitGrid128<T>.GridCells;

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in BitGrid128<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Block128<T>(in BitGrid128<M,N,T> src)
            => src.data.ToBlock();

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<M,N,T>(in BitGrid128<T> src)
            => new BitGrid128<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<M,N,T>(in Block128<T> src)
            => new BitGrid128<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<M,N,T>(Vector128<T> src)
            => new BitGrid128<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<T>(in BitGrid128<M,N,T> src)
            => new BitGrid128<T>(src.data);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> operator & (in BitGrid128<M,N,T> gx, in BitGrid128<M,N,T> gy)
            => BitGrid.and(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> operator | (in BitGrid128<M,N,T> gx, in BitGrid128<M,N,T> gy)
            => BitGrid.or(gx, gy);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> operator ^ (in BitGrid128<M,N,T> gx, in BitGrid128<M,N,T> gy)
            => BitGrid.xor(gx, gy);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> operator ~ (in BitGrid128<M,N,T> gx)
            => BitGrid.not(gx);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> operator - (in BitGrid128<M,N,T> gx)
            => BitGrid.negate(gx);

        [MethodImpl(Inline)]
        public static bit operator ==(in BitGrid128<M,N,T> g1, in BitGrid128<M,N,T> g2)
            => BitGrid.same(g1,g2);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitGrid128<M,N,T> g1, in BitGrid128<M,N,T> g2)
            => !BitGrid.same(g1,g2);
        
        [MethodImpl(Inline)]
        internal BitGrid128(Vector128<T> data)
            => this.data = data;
        
        [MethodImpl(Inline)]
        internal BitGrid128(in Block128<T> src)
            => this.data = src.TakeVector();

        public Vector128<T> Data
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
        public bool Equals(BitGrid128<M,N,T> rhs)
            => ginx.vtestc(ginx.veq(data,rhs));

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}