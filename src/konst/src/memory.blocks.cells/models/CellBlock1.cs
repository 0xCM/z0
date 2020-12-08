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

    using api = CellBlocks;

    /// <summary>
    /// Defines a block b with a capacity of 1 byte
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CellBlock1 : ICellBlock<CellBlock1>
    {
        public Cell8 C;

        /// <summary>
        /// Presents block content as an editable buffer
        /// </summary>
        public Span<byte> Data
        {
            [MethodImpl(Inline)]
           get => cover<CellBlock1,byte>(this, CellCount);
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => CellCount;
        }

        [MethodImpl(Inline)]
        public static implicit operator CellBlock1(byte[] src)
            => api.init(src, out CellBlock1 dst);

        [MethodImpl(Inline)]
        public static implicit operator CellBlock1(byte src)
        {
            var dst = default(CellBlock1);
            dst.C = src;
            return dst;
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CellCount = 1;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CellCount;
    }
}