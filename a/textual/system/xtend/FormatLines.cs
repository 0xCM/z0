//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Seed;
 
    partial class XTend
    {
        /// <summary>
        /// Formats a type that provides intrinsic format capability
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T>(this T src)
            where T : ICustomFormattable
                => src.Format();
 
        public static IEnumerable<string> FormatLines<F>(this IEnumerable<F> items)
            where F : ICustomFormattable
                => items.Select(m => m.Format());
                
        public static void AppendLines<F>(this StringBuilder src, IEnumerable<F> items)
            where F : ICustomFormattable
                => src.AppendLines(items.FormatLines());
    }
}