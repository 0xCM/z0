//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = CharBlocks;

    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock12 : ICharBlock<CharBlock12>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock8 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock4 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock12,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock12(string src)
            => api.init(src, out CharBlock12 dst);

        public const ushort CharCount = 12;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 13x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock13 : ICharBlock<CharBlock13>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock12 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock13,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock13(string src)
            => api.init(src, out CharBlock13 dst);

        public const ushort CharCount = 13;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 14x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock14 : ICharBlock<CharBlock14>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock7 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock7 Hi;

        public const ushort CharCount = 14;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 15x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock15 : ICharBlock<CharBlock15>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock10 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock5 Hi;

        [MethodImpl(Inline)]
        public static implicit operator CharBlock15(string src)
            => api.init(src, out CharBlock15 dst);

        public const ushort CharCount = 15;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 16x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock16 : ICharBlock<CharBlock16>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock8 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock8 Hi;

        [MethodImpl(Inline)]
        public static implicit operator CharBlock16(string src)
            => api.init(src, out CharBlock16 dst);

        public static CharBlock16 Empty => RP.Spaced16;

        public const ushort CharCount = 16;
    }

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

        [MethodImpl(Inline)]
        public static implicit operator CharBlock32(string src)
            => api.init(src, out CharBlock32 dst);

        public static CharBlock32 Empty => RP.Spaced32;

        public const ushort CharCount = 32;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 64x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock64 : ICharBlock<CharBlock64>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock32 Lo;

        public CharBlock32 Hi;

        [MethodImpl(Inline)]
        public static implicit operator CharBlock64(string src)
            => api.init(src, out CharBlock64 dst);

        public static CharBlock64 Empty => RP.Spaced64;

        public const ushort CharCount = 64;
    }

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

        [MethodImpl(Inline)]
        public static implicit operator CharBlock128(string src)
            => api.init(src, out CharBlock128 dst);

        public const ushort CharCount = 128;

    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 256x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock256 : ICharBlock<CharBlock256>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock128 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock128 Hi;

        [MethodImpl(Inline)]
        public static implicit operator Pair<CharBlock128>(in CharBlock256 src)
            => pair(src.Lo, src.Hi);

        [MethodImpl(Inline)]
        public static implicit operator CharBlock256(in Pair<CharBlock128> src)
        {
            var dst = default(CharBlock256);
            dst.Lo = src.Left;
            dst.Hi = src.Right;
            return dst;
        }

        public const ushort CharCount = 256;
    }


}