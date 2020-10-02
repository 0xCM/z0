//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = CharBlocks;
    using B = CharBlock3;

    /// <summary>
    /// Defines a character block b with capacity(b) = 3x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock3 : ICharBlock<B>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock2 Lo;

        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<B,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator B(string src)
            => api.init(src, out B dst);

        public uint Length
        {
            [MethodImpl(Inline)]
            get => CharCount;
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 3;
    }
}