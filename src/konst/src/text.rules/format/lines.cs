//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct TextRules
    {
        partial struct Format
        {
            /// <summary>
            /// Appends each source items to a target stream, appending an EOL after each
            /// </summary>
            /// <param name="src">The data source</param>
            [Op]
            public static string lines(params string[] src)
            {
                var dst = text.build();
                foreach(var item in src)
                    dst.AppendLine(item.Trim());
                return dst.ToString();
            }
        }
    }
}