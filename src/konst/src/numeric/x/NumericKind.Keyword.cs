//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static NumericKinds;

    partial class XNumericKind
    {
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
    }
}