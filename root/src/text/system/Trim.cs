//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    partial class TextExtensions
    {
        public static IEnumerable<string> Trim(this IEnumerable<string> src)
            => src.Select(s => s.Trim());

        public static string[] Trim(this string[] src)
            => src.Map(s => s.Trim());
    }
}