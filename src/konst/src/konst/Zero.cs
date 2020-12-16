//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z = Zero;

    partial struct Konst
    {
        /// <summary>
        /// Zero, presented as an 8-bit signed integer
        /// </summary>
        public const sbyte Zero8i = 0;

        /// <summary>
        /// Zero, presented as an 8-bit unsigned integer
        /// </summary>
        public const byte Zero8u = 0;

        /// <summary>
        /// Zero, presented as a 16-bit signed integer
        /// </summary>
        public const short Zero16i = 0;

        /// <summary>
        /// Zero, presented as a 16-bit unsigned integer
        /// </summary>
        public const ushort Zero16u = 0;

        /// <summary>
        /// Zero, presented as a 32-bit signed integer
        /// </summary>
        public const int Zero32i = 0;

        /// <summary>
        /// Zero, presented as a 32-bit unsigned integer
        /// </summary>
        public const uint Zero32u = 0;

        /// <summary>
        /// Zero, presented as a 64-bit signed integer
        /// </summary>
        public const long Zero64i = 0;

        /// <summary>
        /// Zero, presented as a 64-bit unsigned integer
        /// </summary>
        public const ulong Zero64u = 0;

        /// <summary>
        /// Zero, presented as a 32-bit floating-point number
        /// </summary>
        public const float Zero32f = 0;

        /// <summary>
        /// Zero, presented as a 64-bit floating-point number
        /// </summary>
        public const double Zero64f = 0;

        /// <summary>
        /// Zero, presented as a 128-bit floating-point number
        /// </summary>
        public const decimal Zero128f = 0;

        /// <summary>
        /// Zero, presented as a character
        /// </summary>
        public const char Zero16c = (char)0;

        /// <summary>
        /// Zero, presented as a boolean
        /// </summary>
        public const bool Zero8b = false;

        /// <summary>
        /// The zero-value for an 8-bit signed integer
        /// </summary>
        public const sbyte z8i = Z.z8i;

        /// <summary>
        /// The zero-value for an 8-bit usigned integer
        /// </summary>
        public const byte z8 = Z.z8;

        /// <summary>
        /// The zero-value for a 16-bit signed integer
        /// </summary>
        public const short z16i = Z.z16i;

        /// <summary>
        /// The zero-value for a 16-bit unsigned integer
        /// </summary>
        public const ushort z16 = Z.z16;

        /// <summary>
        /// The zero-value for a 32-bit signed integer
        /// </summary>
        public const int z32i = Z.z32i;

        /// <summary>
        /// The zero-value for a 32-bit usigned integer
        /// </summary>
        public const uint z32 = Z.z32i;

        /// <summary>
        /// The zero-value for a 64-bit signed integer
        /// </summary>
        public const long z64i = Z.z64i;

        /// <summary>
        /// The zero-value for a 64-bit usigned integer
        /// </summary>
        public const ulong z64 = Z.z64;

        /// <summary>
        /// Zero, presented as a character
        /// </summary>
        public const char z16c = Z.z16c;

        /// <summary>
        /// The zero-value for a 32-bit float
        /// </summary>
        public const float z32f = Z.z32f;

        /// <summary>
        /// The zero-value for a 64-bit float
        /// </summary>
        public const double z64f = Z.z64f;

        /// <summary>
        /// The zero-value for a 128-bit float
        /// </summary>
        public const decimal z128f = Z.z128f;

        /// <summary>
        /// The zero-value for a bool
        /// </summary>
        public const bool z8b = Z.z8b;

        /// <summary>
        /// The zero-value for a string
        /// </summary>
        public const string zS = Z.zS;
    }
}