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
    public struct CharBlock11 : ICharBlock<CharBlock11>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock10 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock11,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock11(string src)
            => api.init(src, out CharBlock11 dst);

        public static CharBlock11 Empty => RP.Spaced11;

        public const ushort CharCount = 11;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}