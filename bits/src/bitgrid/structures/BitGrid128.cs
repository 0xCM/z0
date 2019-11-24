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

    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid128<T>
        where T : unmanaged
    {                
        readonly Vector128<T> data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 16;

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
        public static implicit operator Vector128<T>(in BitGrid128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<T>(Vector128<T> src)
            => new BitGrid128<T>(src);

        [MethodImpl(Inline)]
        internal BitGrid128(Vector128<T> data)
            => this.data = data;
        
        [MethodImpl(Inline)]
        internal BitGrid128(Block128<T>  src)
            => this.data = src.TakeVector();

        public int Count
        {
            [MethodImpl(Inline)]
            get => CellCount;
        }

    }
}