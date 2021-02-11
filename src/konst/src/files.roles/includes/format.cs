//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Includes
    {
        [Op]
        public static string format(IncludePath src, PathSeparator sep, bool quote)
        {
            var dst = text.buffer();
            root.iter(src.Entries, include => dst.AppendFormat("{0};", include.Format(sep, quote)));
            return dst.Emit();
        }
    }
}