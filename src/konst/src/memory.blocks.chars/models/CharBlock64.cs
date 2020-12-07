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
    /// Defines a character block b with capacity(b) = 64x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock64 : ICharBlock<CharBlock64>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock32 Lo;

        public CharBlock32 Hi;

        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock64,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock64(string src)
            => api.init(src, out CharBlock64 dst);

        public static CharBlock64 Empty => RP.Spaced64;

        public const ushort CharCount = 64;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }

}