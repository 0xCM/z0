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

    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock8 : ICharBlock<CharBlock8>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock4 Lo;

        public CharBlock4 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock8,char>(this, CharCount);
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
        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CharBlock8(string src)
            => api.init(src, out CharBlock8 dst);

        public static CharBlock8 Empty => RP.Spaced8;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 8;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}