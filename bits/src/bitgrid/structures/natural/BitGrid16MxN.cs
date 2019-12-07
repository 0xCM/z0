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
    /// A grid of natural dimensions M and N such that M*N = 16
    /// </summary>
    /// <remarks>
    ///  Conforming dimensions include 1x16, 16x1, 2x8, 8x2, and 4x4
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid16<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly ushort data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 2;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dimension => default;        
        
        [MethodImpl(Inline)]
        public static implicit operator BitGrid16<M,N,T>(ushort src)
            => new BitGrid16<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(BitGrid16<M,N,T> src)
            => src.data;
        
        [MethodImpl(Inline)]
        public static implicit operator BitGrid16<M,N,T>(in Block16<T> src)
            => new BitGrid16<M, N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitGrid16<M,N,T> g1, BitGrid16<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(BitGrid16<M,N,T> g1, BitGrid16<M,N,T> g2)
            => !g1.Equals(g2);

        [MethodImpl(Inline)]
        internal BitGrid16(ushort src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal BitGrid16(Block16<T> src)
            => this.data = src.As<ushort>().Head;

        public ushort Data
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

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.AsBytes().As<T>();
        }

        /// <summary>
        /// The leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Cells);
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
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Extracts row contant as a bitvector
        /// </summary>
        public BitVector<N,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => BitGrid.row(this,index);
        }

        [MethodImpl(Inline)]
        public BitGrid16<M,N,U> As<U>()
            where U : unmanaged
                => new BitGrid16<M,N,U>(data);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid16<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}