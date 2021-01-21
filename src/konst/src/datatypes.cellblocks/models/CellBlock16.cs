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
    using B = CellBlock16;

    /// <summary>
    /// Defines a block with a capacity of 16 bytes
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = Size)]
    public struct CellBlock16 : ICellBlock<B>
    {
        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const byte Size = 16;

        Cell64 Lo;

        Cell64 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public ReadOnlySpan<byte> Data
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