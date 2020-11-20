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
    /// Defines a character block b with capacity(b) = 512x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock512 : ICharBlock<CharBlock512>
    {
        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock256 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock256 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock512,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator Pair<CharBlock256>(CharBlock512 src)
            => pair(src.Lo, src.Hi);

        [MethodImpl(Inline)]
        public static implicit operator CharBlock512(string src)
            => api.init(src, out CharBlock512 dst);

        public static CharBlock512 Empty => RP.Spaced512;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 512;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}