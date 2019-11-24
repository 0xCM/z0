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
    /// Defines a grid of 32 bits ostensibly sharded over generic cells
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid32<T>
        where T : unmanaged
    {                
        readonly uint data;        

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 4;

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
        public static implicit operator BitGrid32<T>(uint src)
            => new BitGrid32<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(BitGrid32<T> src)
            => src.data;

        [MethodImpl(Inline)]
        internal BitGrid32(uint data)
            => this.data = data;
        
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

        public uint Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid32<T> rhs)
            => data.Equals(rhs.data);
    }
}