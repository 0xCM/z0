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
    using B = CellBlock2;

    /// <summary>
    /// Defines a block with a capacity of two bytes
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CellBlock2 : ICellBlock<B>
    {
        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = 2;

        CellBlock1 Lo;

        CellBlock1 Hi;

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

        public static B Empty => default;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CellCount = 2;


    }
}