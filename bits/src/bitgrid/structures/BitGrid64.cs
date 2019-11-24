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
    /// Defines a grid of 64 bits ostensibly sharded over generic cells
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid64<T>
        where T : unmanaged
    {                
        readonly ulong data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 8;

        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = ByteCount * 8;
        
        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int CellCount => ByteCount/size<T>();

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => bitsize<T>();

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<T>(ulong src)
            => new BitGrid64<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitGrid64<T> src)
            => src.data;

        [MethodImpl(Inline)]
        internal BitGrid64(ulong data)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitGrid64(Block64<T>  src)
            => this.data = src.As<ulong>().Head;

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

        public int Count
        {
            [MethodImpl(Inline)]
            get => CellCount;
        }

        public ulong Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<T> rhs)
            => data.Equals(rhs.data);
    }
}