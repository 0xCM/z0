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
        /// Specifies the C# keyword used to designate a primal numeric type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static string NumericKeyword(this Type src)
            => src.NumericKind().Keyword();

        /// <summary>
        /// Specifies the keyword not used in C# to designate a primal numeric type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static string NumericKeywordNot(this Type src)
            => src.NumericKind().KeywordNot();
    }
}