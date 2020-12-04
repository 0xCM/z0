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
    using B = CharBlock2;

    /// <summary>
    /// Defines a character block b with capacity(b) = 2x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock2 : ICharBlock<B>
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
           get => cover<B,char>(this, CharCount);
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => CharCount;
        }

        [MethodImpl(Inline)]
        public static implicit operator Pair<CharBlock1>(B src)
            => pair(src.Lo, src.Hi);

        [MethodImpl(Inline)]
        public static implicit operator B(string src)
            => api.init(src, out B dst);

        public static B Empty => RP.Spaced2;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 2;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}