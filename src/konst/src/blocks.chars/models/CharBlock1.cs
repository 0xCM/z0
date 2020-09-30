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

    /// <summary>
    /// Defines a character block b with capacity(b) = 1x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock1 : ICharBlock<CharBlock1>
    {
        public char C;

        /// <summary>
        /// Presents block content as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock1,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock1(string src)
            => api.init(src, out CharBlock1 dst);

        [MethodImpl(Inline)]
        public static implicit operator CharBlock1(char src)
        {
            var dst = default(CharBlock1);
            dst.C = src;
            return dst;
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 1;
    }
}