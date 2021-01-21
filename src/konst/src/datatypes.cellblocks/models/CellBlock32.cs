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
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = 32;

        /// <summary>
        /// The lower content
        /// </summary>
        Cell128 Lo;

        Cell128 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<byte> Data
        {
            [MethodImpl(Inline)]
           get => cover<B,byte>(this, Size);
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        [MethodImpl(Inline)]
        public static implicit operator B(byte[] src)
            => api.init(src, out B dst);
    }
}