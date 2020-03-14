//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N = W := 128
    /// </summary>
    /// <remarks>Conforming dimensions include 1x128, 128x1, 2x64, 64x2, 4x32, 32x4, 8x16, and 16x8</remarks>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentity))]    
    public readonly ref struct BitGrid128<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        internal readonly Vector128<T> data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 16;

        /// <summary>
        /// The grid width
        /// </summary>
        public static N128 W => default;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in BitGrid128<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Block128<T>(in BitGrid128<M,N,T> src)
            => src.data.ToBlock();

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<M,N,T>(in Block128<T> src)
            => new BitGrid128<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<M,N,T>(Vector128<T> src)
            => new BitGrid128<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<M,N,T>(Vector128<byte> src)
            => new BitGrid128<M,N,T>(src.As<byte,T>());

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
            => this.data = src.LoadVector();

        public Vector128<T> Data
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
        public bool Equals(BitGrid128<M,N,T> rhs)
            => gvec.vtestc(gvec.veq(data,rhs));

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}