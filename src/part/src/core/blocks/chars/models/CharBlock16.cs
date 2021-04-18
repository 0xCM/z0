//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static memory;

    using api = CharBlocks;

    /// <summary>
    /// Defines a character block b with capacity(b) = 16x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock16 : ICharBlock<CharBlock16>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock8 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock8 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock16,char>(this, CharCount);
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref char First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock16(string src)
            => api.init(src, out CharBlock16 dst);

        public static CharBlock16 Empty => RP.Spaced16;

        public const ushort CharCount = 16;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}