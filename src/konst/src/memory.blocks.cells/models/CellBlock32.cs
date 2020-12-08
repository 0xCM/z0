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
    using B = CellBlock32;

    /// <summary>
    /// Defines a block with a capacity of 32 bytes
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CellBlock32 : ICellBlock<B>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public Cell128 Lo;

        public Cell128 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
           get => cover<B,byte>(this, CellCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator B(byte[] src)
            => api.init(src, out B dst);

        public uint Length
        {
            [MethodImpl(Inline)]
            get => CellCount;
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CellCount = 32;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CellCount;
    }
}