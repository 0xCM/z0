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

    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock9 : ICharBlock<CharBlock9>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock8 A;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock1 B;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock9,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock9(string src)
            => api.init(src, out CharBlock9 dst);

        public static CharBlock9 Empty => RP.Spaced9;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 9;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}