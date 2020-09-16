//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = StorageBlocks;

    /// <summary>
    /// Defines a character block b with capacity(b) = 1x16u
    /// </summary>
    public struct CharBlock1 : ICharBlock<CharBlock1>
    {
        public char Data;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 2x16u
    /// </summary>
    public struct CharBlock2 : ICharBlock<CharBlock2>
    {
        [MethodImpl(Inline)]
        public static implicit operator Pair<CharBlock1>(CharBlock2 src)
            => pair(src.Lo, src.Hi);

        public CharBlock1 Lo;

        public CharBlock1 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 3x16u
    /// </summary>
    public struct CharBlock3
    {
        public CharBlock2 Lo;

        public CharBlock1 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 4x16u
    /// </summary>
    public struct CharBlock4 : ICharBlock<CharBlock4>
    {
        public CharBlock2 Lo;

        public CharBlock2 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 5
    /// </summary>
    public struct CharBlock5
    {
        public CharBlock4 Lo;

        public CharBlock1 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 6
    /// </summary>
    public struct CharBlock6
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock5 Lo;

        public CharBlock1 Hi;
    }

    public struct CharBlock7
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock6 Lo;

        public CharBlock1 Hi;
    }

    public struct CharBlock8 : ICharBlock<CharBlock8>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock4 Lo;

        public CharBlock4 Hi;
    }

    public struct CharBlock9
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock8 A;

        public CharBlock1 B;
    }

    public struct CharBlock10
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock8 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock2 Hi;
    }

    public struct CharBlock11
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock10 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock1 Hi;
    }

    public struct CharBlock12
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock8 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock4 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 13x16u
    /// </summary>
    public struct CharBlock13
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock12 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock1 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 14x16u
    /// </summary>
    public struct CharBlock14
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock7 Lo;

        public CharBlock7 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 15x16u
    /// </summary>
    public struct CharBlock15
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock10 Lo;

        public CharBlock5 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 16x16u
    /// </summary>
    public struct CharBlock16 : ICharBlock<CharBlock16>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock8 Lo;

        public CharBlock8 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 32x16u
    /// </summary>
    public struct CharBlock32  : ICharBlock<CharBlock32>
    {
        public static CharBlock32 Empty => "                                ";

        [MethodImpl(Inline)]
        public static implicit operator CharBlock32(string src)
            => api.init(src, out CharBlock32 dst);

        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock16 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock16 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 64x16u
    /// </summary>
    public struct CharBlock64 : ICharBlock<CharBlock64>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock32 Lo;

        public CharBlock32 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 128x16u
    /// </summary>
    public struct CharBlock128 : ICharBlock<CharBlock128>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock64 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock64 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 256x16u
    /// </summary>
    public struct CharBlock256
    {
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

        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock128 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock128 Hi;
    }

    /// <summary>
    /// Defines a character block b with capacity(b) = 512x16u
    /// </summary>
    public struct CharBlock512
    {
        [MethodImpl(Inline)]
        public static implicit operator Pair<CharBlock256>(CharBlock512 src)
            => pair(src.Lo, src.Hi);

        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock256 Lo;

        /// <summary>
        /// The lower segment
        /// </summary>
        public CharBlock256 Hi;
    }
}