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

    [StructLayout(LayoutKind.Sequential, Pack=2)]
    public struct CharBlock10 : ICharBlock<CharBlock10>
    {
        CharBlock8 Lo;

        CharBlock2 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock10,char>(this, CharCount);
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref char First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public uint Count => CharCount;

        public int Length => CharCount;

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CharBlock10(string src)
            => api.init(src, out CharBlock10 dst);

        public static CharBlock10 Empty => RP.Spaced10;

        public static CharBlock10 Null => default;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 10;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}