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
    public struct CharBlock10 : ICharBlock<CharBlock10>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock8 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock2 Hi;

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

        [MethodImpl(Inline)]
        public static implicit operator CharBlock10(string src)
            => api.init(src, out CharBlock10 dst);

        public static CharBlock10 Empty => RP.Spaced10;

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