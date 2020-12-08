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

    /// <summary>
    /// Defines a character block b with capacity(b) = 256x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock256 : ICharBlock<CharBlock256>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock128 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock128 Hi;

        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock256,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock256(in Pair<CharBlock128> src)
        {
            var dst = default(CharBlock256);
            dst.Lo = src.Left;
            dst.Hi = src.Right;
            return dst;
        }

        public const ushort CharCount = 256;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}