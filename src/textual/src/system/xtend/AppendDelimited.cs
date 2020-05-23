//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    partial class XTend
    {
        public static void AppendDelimited<T>(this StringBuilder sb, object content, T pad, char delimiter)
            where T : unmanaged, Enum
        {
            if(sb == null)
                throw new Exception("Your string builder is null!!");

            sb.Append(text.rspace(delimiter));            
            sb.Append($"{content}".PadRight(EnumFormatter.numeric<T,int>(pad)));
        }

        public static void AppendLines<F>(this StringBuilder src, IEnumerable<F> items)
            where F : ITextual
                => src.AppendLines(Formattable.items(items));

    }
}