//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N <= W := 32
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentityProvider))]
    public struct SubGrid32<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        /// <summary>
        /// The grid state
        /// </summary>
        internal uint Data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 4;

        [MethodImpl(Inline)]
        public SubGrid32(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        internal SubGrid32(SpanBlock32<T> src)
            => Data = src.As<uint>().First;

        /// <summary>
        /// The exposed grid state
        /// </summary>
        public uint Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => Data.Bytes().Recover<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref first(Cells);
        }

        public uint CellCount
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
            get => (int)NatCalc.mul<M,N>();
        }

        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public int RowCount => nat32i<M>();

        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public int ColCount => nat32i<N>();

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Extracts row content as a bitvector
        /// </summary>
        public BitVector<N,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => BitGrid.row(this, index);
        }

        [MethodImpl(Inline)]
        public SubGrid32<M,N,U> As<U>()
            where U : unmanaged
                => new SubGrid32<M, N, U>(Data);

        [MethodImpl(Inline)]
        public bool Equals(SubGrid32<M,N,T> rhs)
            => Data.Equals(rhs.Data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();


        [MethodImpl(Inline)]
        public static implicit operator SubGrid32<M,N,T>(in SpanBlock32<T> src)
            => new SubGrid32<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid32<M,N,T>(uint src)
            => new SubGrid32<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(SubGrid32<M,N,T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid32<T>(SubGrid32<M,N,T> src)
            => new BitGrid32<T>(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid32<M,N,T>(BitGrid32<T> src)
            => new SubGrid32<M,N,T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(SubGrid32<M,N,T> g1, SubGrid32<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(SubGrid32<M,N,T> g1, SubGrid32<M,N,T> g2)
            => !g1.Equals(g2);
    }
}