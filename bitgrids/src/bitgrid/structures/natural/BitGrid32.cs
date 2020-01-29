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

    using static zfunc;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N = W := 32
    /// </summary>
    /// <remarks>Conforming dimensions include 1x32, 32x1, 2x16, 16x2, 4x8, and 8x4</remarks>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentity))]
    public readonly ref struct BitGrid32<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly uint data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 4;

        /// <summary>
        /// The grid width
        /// </summary>
        public static N32 W => default;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dimension => default;        
        
        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<M,N,T>(uint src)
            => new BitGrid32<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(BitGrid32<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<T>(BitGrid32<M,N,T> src)
            => new BitGrid32<T>(src.data, natval<M>(), natval<N>());

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
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Extracts row contant as a bitvector
        /// </summary>
        public BitVector<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => BitGrid.row(this,row);
        }

        /// <summary>
        /// Converts the current grid defined over T-cells to a target grid defined over U-cells
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public BitGrid32<M,N,U> As<U>()
            where U : unmanaged
                => new BitGrid32<M, N, U>(data);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid32<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}