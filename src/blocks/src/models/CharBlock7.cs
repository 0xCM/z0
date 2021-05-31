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

    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock7 : ICharBlock<CharBlock7>
    {
        CharBlock6 Lo;

        CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock7,char>(this, CharCount);
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
        public static implicit operator CharBlock7(string src)
            => api.init(src, out CharBlock7 dst);

        public static CharBlock7 Empty => RP.Spaced7;

        public static CharBlock7 Null => default;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 7;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}