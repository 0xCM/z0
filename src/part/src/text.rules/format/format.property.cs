//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        partial struct Format
        {
            [Op, Closures(Closure)]
            public static string format<T>(PropFormat<T> src, char sep = RP.PropertySep)
                => string.Format("{0}{1}{2}",
                    string.Format(RP.pad(src.Pad), src.Name),
                    string.Format("{0}",sep),
                        src.Value);

            [Op]
            public static string format(PropFormat src, char sep = RP.PropertySep)
                => string.Format("{0}{1}{2}",
                    string.Format(RP.pad(src.Pad), src.Name),
                    string.Format("{0}", sep),
                        src.Value);
        }
    }
}