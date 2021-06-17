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
    public struct CharBlock8 : ICharBlock<CharBlock8>
    {
        CharBlock4 Lo;

        CharBlock4 Hi;

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

        public uint Capacity
            => CharCount;

        public int Length
        {
            [MethodImpl(Inline)]
            get => api.length(this);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CharBlock8(string src)
            => api.init(src, out CharBlock8 dst);

        [MethodImpl(Inline)]
        public static implicit operator CharBlock8(ReadOnlySpan<char> src)
        {
            var dst = Empty;
            var count = min(src.Length, CharCount);
            var data = dst.Data;
            for(var i=0; i<count; i++)
                seek(data,i) = skip(src,i);
            return dst;
        }

        public static CharBlock8 Empty => RP.Spaced8;

        public static CharBlock8 Null => default;

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