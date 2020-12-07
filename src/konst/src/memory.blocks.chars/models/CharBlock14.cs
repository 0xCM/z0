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

    using api = CharBlocks;

    /// <summary>
    /// Defines a character block b with capacity(b) = 14x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock14 : ICharBlock<CharBlock14>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock7 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock7 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock14,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock14(string src)
            => api.init(src, out CharBlock14 dst);

        public static CharBlock14 Empty => RP.Spaced14;

        public const ushort CharCount = 14;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}