//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    partial class XTend
    {
        /// <summary>
        /// Specifies the C# keyword used to designate a kind-identified numeric type
        /// </summary>
        public static string Keyword(this NumericKind k)
            => NumericKinds.keyword(k);

        /// <summary>
        /// Specifies the keyword not used in C# to designate a kind-identified primal type
        /// </summary>
        public static string KeywordNot(this NumericKind k)
            => NumericKinds.nonkeyword(k);
    }
}