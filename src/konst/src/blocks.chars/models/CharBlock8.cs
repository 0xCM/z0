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
    public struct CharBlock8 : ICharBlock<CharBlock8>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock4 Lo;

        public CharBlock4 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock8,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock8(string src)
            => api.init(src, out CharBlock8 dst);

        public static CharBlock8 Empty => RP.Spaced8;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 8;
    }

}