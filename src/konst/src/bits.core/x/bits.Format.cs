//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial class XTend
    {
        public static string Format(this IEnumerable<Bit32> src, bool reversed = true)
        {
            var chars = src.Select(x => x.ToChar()).ToArray();
            if(reversed)
                return new string(chars.Reverse());
            else
                return new string(chars);
        }
    }
}