//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Memories
    {
        /// <summary>
        /// The bit-width of an 8-bit unsigned integer
        /// </summary>
        public const byte Width8u = 8;

        /// <summary>
        /// The bit-width of a 16-bit unsigned integer
        /// </summary>
        public const byte Width16u = 16;

        /// <summary>
        /// The bit-width of a 32-bit unsigned integer
        /// </summary>
        public const byte Width32u = 32;

        /// <summary>
        /// The bit-width of a 32-bit unsigned integer
        /// </summary>
        public const byte Width64u = 64;

        public static W8 w8 => default(W8);

        public static W16 w16 => default(W16);

        public static W32 w32 => default(W32);

        public static W64 w64 => default(W64);

        public static W128 w128 => default(W128);

        public static W256 w256 => default(W256);

        public static W512 w512 => default(W512);

        public static W1024 w1024 => default(W1024);
    }
}