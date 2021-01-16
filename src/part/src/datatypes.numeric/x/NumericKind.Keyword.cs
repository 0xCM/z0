//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XNumeric
    {
        /// <summary>
        /// Specifies the C# keyword used to designate a kind-identified numeric type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static string Keyword(this NumericKind k)
            => Numeric.keyword(k);

        /// <summary>
        /// Specifies the keyword not used in C# to designate a kind-identified primal type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static string KeywordNot(this NumericKind k)
            => Numeric.nonkeyword(k);
    }
}