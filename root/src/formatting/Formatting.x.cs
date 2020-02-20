//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    /// <summary>
    /// Exposes formatting capabilites via exension methods
    /// </summary>
    public static class CustomFormattableX
    {
        /// <summary>
        /// Formats any object, using a custom configurable formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        /// <param name="src">The format configuration</param>
        [MethodImpl(Inline)]
        public static string Format(this object src, IFormatConfig config)
            => Formatting.format(src, config);

        /// <summary>
        /// Formats a type that provides intrinsic format capability
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T>(this T src)
            where T : ICustomFormattable
                => src.Format();
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