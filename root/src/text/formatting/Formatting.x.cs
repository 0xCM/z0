//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Text;

    using static Root;

    /// <summary>
    /// Exposes formatting capabilites via exension methods
    /// </summary>
    public static partial class FormattingOps
    {
        /// <summary>
        /// Joins a sequence of source characters with optional interspersed separator
        /// </summary>
        /// <param name="chars">The characters to join</param>
        /// <param name="sep">The character to intersperse</param>
        public static string Concat(this IEnumerable<char> chars, char? sep = null)
        {
            if(sep == null)
                return new string(chars.ToSpan());
            else
                return new string(chars.Intersperse(sep.Value).ToSpan());                        
        }

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