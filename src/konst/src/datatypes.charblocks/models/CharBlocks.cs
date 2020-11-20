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

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock14,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock14(string src)
            => api.init(src, out CharBlock14 dst);

        public static CharBlock14 Empty => RP.Spaced14;

        public const ushort CharCount = 14;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
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

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock15,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock15(string src)
            => api.init(src, out CharBlock15 dst);

        public static CharBlock15 Empty => RP.Spaced15;

        public const ushort CharCount = 15;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
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

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock16,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock16(string src)
            => api.init(src, out CharBlock16 dst);

        public static CharBlock16 Empty => RP.Spaced16;

        public const ushort CharCount = 16;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
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

        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock64,char>(this, CharCount);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock64(string src)
            => api.init(src, out CharBlock64 dst);

        public static CharBlock64 Empty => RP.Spaced64;

        public const ushort CharCount = 64;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
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

        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock128,char>(this, CharCount);
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