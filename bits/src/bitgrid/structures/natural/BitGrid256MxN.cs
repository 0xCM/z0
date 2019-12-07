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
    /// A grid of natural dimensions M and N such that M*N = 256
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid256<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        internal readonly Vector256<T> data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 32;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;

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
        public static implicit operator BitGrid256<M,N,T>(Vector256<T> src)
            => new BitGrid256<M,N,T>(src);


        [MethodImpl(Inline)]
        public static implicit operator BitGrid256<M,N,T>(Vector256<byte> src)
            => new BitGrid256<M,N,T>(src.As<byte,T>());

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
            => this.data = src.LoadVector();
        
        public Vector256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
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
            get => NatMath.mul<M,N>();
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
        /// Reads an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public T Cell(int cell)
            => data.GetElement(cell);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid256<M,N,T> rhs)
            => BitGrid.same(this,rhs);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}