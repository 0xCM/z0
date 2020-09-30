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
    /// Defines a character block b with capacity(b) = 2x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock2 : ICharBlock<CharBlock2>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock1 Lo;

        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock2,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator Pair<CharBlock1>(CharBlock2 src)
            => pair(src.Lo, src.Hi);

        [MethodImpl(Inline)]
        public static implicit operator CharBlock2(string src)
            => api.init(src, out CharBlock2 dst);

        public static CharBlock2 Empty => RP.Spaced2;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 2;
    }
}