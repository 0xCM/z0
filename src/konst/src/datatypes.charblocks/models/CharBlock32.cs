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
    /// Defines a character block b with capacity(b) = 32x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock32  : ICharBlock<CharBlock32>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock16 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock16 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock32,char>(this, CharCount);
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
        public static implicit operator CharBlock32(string src)
            => api.init(src, out CharBlock32 dst);

        public static CharBlock32 Empty => RP.Spaced32;

        public const ushort CharCount = 32;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}