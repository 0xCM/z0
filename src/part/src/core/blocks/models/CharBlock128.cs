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
    using static core;

    using api = CharBlocks;

    /// <summary>
    /// Defines a character block b with capacity(b) = 128x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock128 : ICharBlock<CharBlock128>
    {
        CharBlock64 Lo;

        CharBlock64 Hi;

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

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CharBlock128(string src)
            => api.init(src, out CharBlock128 dst);

        public static CharBlock128 Empty => RP.Spaced128;

        public static CharBlock128 Null => default;

        public const ushort CharCount = 128;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }

}