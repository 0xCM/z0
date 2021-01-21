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
    using B = CellBlock4;

    /// <summary>
    /// Defines a block with a capacity of four bytes
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CellBlock4 : ICellBlock<B>
    {
        /// <summary>
        /// The block capacity
        /// </summary>
        public const uint Size = 4;

        CellBlock2 Lo;

        CellBlock2 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
           get => cover<B,byte>(this, Size);
        }

        [MethodImpl(Inline)]
        public static implicit operator B(byte[] src)
            => api.init(src, out B dst);

        public uint Length
        {
            [MethodImpl(Inline)]
            get => Size;
        }


    }
}