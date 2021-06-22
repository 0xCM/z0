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
    using static core;
    using static Typed;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N <= W := 128
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentityProvider))]
    public struct SubGrid128<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        /// <summary>
        /// The grid state
        /// </summary>
        internal Vector128<T> Data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 16;

        /// <summary>
        /// The maximum grid width
        /// </summary>
        public static W128 W => default;

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in SubGrid128<M,N,T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator SpanBlock128<T>(in SubGrid128<M,N,T> src)
            => src.Data.ToBlock();

        [MethodImpl(Inline)]
        public static implicit operator SubGrid128<M,N,T>(in SpanBlock128<T> src)
            => new SubGrid128<M, N, T>(src);


        [MethodImpl(Inline)]
        public static implicit operator SubGrid128<M,N,T>(Vector128<T> src)
            => new SubGrid128<M,N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid128<M,N,T>(Vector128<byte> src)
            => new SubGrid128<M,N,T>(src.As<byte,T>());

        [MethodImpl(Inline)]
        internal SubGrid128(Vector128<T> data)
            => this.Data = data;

        [MethodImpl(Inline)]
        internal SubGrid128(in SpanBlock128<T> src)
            => this.Data = src.LoadVector();

        /// <summary>
        /// The exposed grid state
        /// </summary>
        public Vector128<T> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => Data.ToSpan<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref first(Cells);
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
        /// The number of covered bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => (int)NatCalc.mul<M,N>();
        }

        /// <summary>
        /// Reads an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public T Cell(int cell)
            => Data.GetElement(cell);

        [MethodImpl(Inline)]
        public SubGrid128<M,N,U> As<U>()
            where U : unmanaged
                => Data.As<T,U>();

        [MethodImpl(Inline)]
        public bool Equals(SubGrid128<M,N,T> rhs)
            => gcpu.vsame(Data,rhs.Data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}