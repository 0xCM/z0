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
    /// Defines a character block b with capacity(b) = 128x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock128 : ICharBlock<CharBlock128>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock64 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock64 Hi;

        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock128,char>(this, CharCount);
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
        public static implicit operator CharBlock128(string src)
            => api.init(src, out CharBlock128 dst);

        public static CharBlock128 Empty => RP.Spaced128;

        public const ushort CharCount = 128;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }

}