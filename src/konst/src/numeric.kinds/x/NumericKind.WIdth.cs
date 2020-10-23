//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

    partial class XNumericKinds
    {
        /// <summary>
        /// Determines whether a numeric kind designates a signed integral type
        /// </summary>
        /// <param name="src">The source kind</typeparam>
        [MethodImpl(Inline), Op]
        public static bool IsSigned(this NumericKind src)
            => signed(src);

        /// <summary>
        /// Determines the indicator of a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static NumericIndicator Indicator(this NumericKind src)
            => indicator(src);

        /// <summary>
        /// Specifies the C# keyword used to designate a kind-identified numeric type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static string Keyword(this NumericKind k)
            => keyword(k);

        /// <summary>
        /// Specifies the keyword not used in C# to designate a kind-identified primal type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static string KeywordNot(this NumericKind k)
            => nonkeyword(k);

        /// <summary>
        /// Specifies the C# keyword used to designate a primal numeric type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static string NumericKeyword(this Type src)
            => src.NumericKind().Keyword();

        /// <summary>
        /// Specifies the keyword not used in C# to designate a primal numeric type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static string NumericKeywordNot(this Type src)
            => src.NumericKind().KeywordNot();

        /// <summary>
        /// Determines the width of a numeric kind
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth TypeWidth(this NumericKind kind)
            => width(kind);

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline), Op]
        public static int Width(this NumericKind k)
            => (int)(ushort)k;

        /// <summary>
        /// Determines the width of the represented kind in bytes
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline), Op]
        public static int Size(this NumericKind k)
            => ((int)(ushort)k)/8;
    }
}