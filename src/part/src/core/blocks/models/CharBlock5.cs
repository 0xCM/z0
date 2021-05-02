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
    /// Defines a character block b with capacity(b) = 5
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock5 : ICharBlock<CharBlock5>
    {
        CharBlock4 Lo;

        CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock5,char>(this, CharCount);
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref char First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => CharCount;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CharBlock5(string src)
            => api.init(src, out CharBlock5 dst);

        public static CharBlock5 Empty => RP.Spaced5;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 5;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}