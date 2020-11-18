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
    using B = CharBlock6;

    /// <summary>
    /// Defines a character block b with capacity(b) = 6
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock6 : ICharBlock<B>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock5 Lo;

        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock6,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator B(string src)
            => api.init(src, out B dst);

        public static CharBlock6 Empty => RP.Spaced6;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 6;
    }
}