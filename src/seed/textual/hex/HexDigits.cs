//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static HexSpecs;

    partial class XTend
    {
        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this sbyte src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this byte src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this short src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this ushort src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this int src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this uint src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this long src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string HexDigits(this ulong src, bool uppercase)
            => src.ToString(uppercase ? UC : LC);
    }
}