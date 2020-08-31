//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static Memories;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N = W := 64
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentityProvider))]
    public readonly ref struct BitGrid64<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        /// <summary>
        /// The grid state
        /// </summary>
        internal readonly ulong Data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 8;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<M,N,T>(in SpanBlock64<T> src)
            => new BitGrid64<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<M,N,T>(ulong src)
            => new BitGrid64<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitGrid64<M,N,T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<T>(BitGrid64<M,N,T> src)
            => new BitGrid64<T>(src.Data);

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
            => this.Data = src;

        [MethodImpl(Inline)]
        internal BitGrid64(SpanBlock64<T> src)
            => this.Data = src.As<ulong>().Head;

        public ulong Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => Content.Bytes().Cast<T>();
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
            get => (int)NatCalc.mul<M,N>();
        }

        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public int RowCount => nati<M>();

        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public int ColCount => nati<N>();

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
            get => BitGrid.row(this,index);
        }

        /// <summary>
        /// Converts the current grid defined over T-cells to a target grid defined over U-cells
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public BitGrid64<M,N,U> As<U>()
            where U : unmanaged
                => new BitGrid64<M,N,U>(Data);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<M,N,T> rhs)
            => Data.Equals(rhs.Data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}