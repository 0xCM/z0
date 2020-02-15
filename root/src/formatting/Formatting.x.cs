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
    public static class FormattingX
    {
        /// <summary>
        /// Formats any object, using a custom formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        [MethodImpl(Inline)]
        public static string Format(this object src)
            => Formatting.format(src);

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

        /// <summary>
        /// Formats a type that reifies the custom formattable marker interface
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <param name="config">The format configuration</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T>(this T src, IFormatConfig config)
            where T : ICustomFormattable
                => src.Format(config);
    }
}