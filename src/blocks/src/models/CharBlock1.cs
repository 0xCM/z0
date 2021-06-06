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
    /// Defines a character block b with capacity(b) = 1x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=2)]
    public struct CharBlock1 : ICharBlock<CharBlock1>
    {
        char C;

        /// <summary>
        /// Presents block content as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock1,char>(this, CharCount);
        }

        /// <summary>
        /// Specifies a reference to the leading (only) cell
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

        [MethodImpl(Inline)]
        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CharBlock1(string src)
            => api.init(src, out CharBlock1 dst);

        [MethodImpl(Inline)]
        public static implicit operator CharBlock1(char src)
        {
            var dst = default(CharBlock1);
            dst.C = src;
            return dst;
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 1;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}