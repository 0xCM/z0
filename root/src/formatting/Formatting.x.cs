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
    public static class CustomFormattableX
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

        /// <summary>
        /// Formats a type that provides intrinsic format capability
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T>(this T src, IFormatConfig config)
            where T : IConfiguredCustomFormattable
                => src.Format(config);

        /// <summary>
        /// Formats a type that provides intrinsic format capability
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T,C>(this T src, C config)
            where T : IConfiguredCustomFormattable<C>
                => src.Format(config);
 
        public static IEnumerable<string> FormatLines<F>(this IEnumerable<F> items)
            where F : ICustomFormattable
                => items.Select(m => m.Format());
                
        public static void AppendLines(this StringBuilder src, IEnumerable<string> lines)
            => iter(lines, line => src.AppendLine(line));            

        public static void AppendLines<F>(this StringBuilder src, IEnumerable<F> items)
            where F : ICustomFormattable
            => src.AppendLines(items.FormatLines());
    }

    public static class NumericFormattableX
    {
        [MethodImpl(Inline)]
        public static string Format<F>(this F src)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src);

        [MethodImpl(Inline)]
        public static string Format<F>(this F src, NumericBase @base)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src, @base);
    }
}