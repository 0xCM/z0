//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial class XTend
    {
        /// <summary>
        /// Encloses supplied text in quotation marks
        /// </summary>
        /// <param name="content">The content to be quoted</param>
        public static string Enquote(this string content)
            => $"{Chars.Quote}{content}{Chars.Quote}";
    }
}