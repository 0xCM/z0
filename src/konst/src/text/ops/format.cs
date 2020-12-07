//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class text
    {
        /// <summary>
        /// Formats a pattern using an arbitrary kind/number of arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="args">The pattern arguments</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, params object[] args)
            => string.Format(pattern, args);

        /// <summary>
        /// Formats anything
        /// </summary>
        /// <param name="rest">The formattables to be rendered and concatenated</param>
        [MethodImpl(Inline), Op]
        public static string format(object first)
            => first is ITextual t ? t.Format() : first?.ToString() ?? "!!null!!";

        [Op]
        public static string format(object src, Type t, char delimiter, RenderWidth width)
            => text.rpad(text.format("{0} {1}", delimiter, text.format(src)), width);

        /// <summary>
        /// Formats a pattern using a parametric argument
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The pattern argument</param>
        /// <typeparam name="T">The argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<T>(string pattern, T arg0)
            => string.Format(pattern, arg0 is ITextual t ? t.Format() : $"{arg0}");

        /// <summary>
        /// Formats a pattern using 2 parametric arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <typeparam name="A">The first argument type</typeparam>
        /// <typeparam name="B">The second argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B>(string pattern, A arg0, B arg1)
            => string.Format(pattern,
                arg0 is ITextual t0 ? t0.Format() : $"{arg0}",
                arg1 is ITextual t1 ? t1.Format() : $"{arg1}"
                );

        /// <summary>
        /// Formats a pattern using 3 parametric arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        /// <typeparam name="A">The first argument type</typeparam>
        /// <typeparam name="B">The second argument type</typeparam>
        /// <typeparam name="C">The third argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B,C>(string pattern, A arg0, B arg1, C arg2)
            => string.Format(pattern,
                            arg0 is ITextual t0 ? t0.Format() : $"{arg0}",
                            arg1 is ITextual t1 ? t1.Format() : $"{arg1}",
                            arg2 is ITextual t2 ? t2.Format() : $"{arg2}"
                            );

        /// <summary>
        /// Formats a pattern using 4 parametric arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        /// <typeparam name="A">The first argument type</typeparam>
        /// <typeparam name="B">The second argument type</typeparam>
        /// <typeparam name="C">The third argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B,C,D>(string pattern, A arg0, B arg1, C arg2, D arg3)
            => string.Format(pattern,
                            arg0 is ITextual t0 ? t0.Format() : $"{arg0}",
                            arg1 is ITextual t1 ? t1.Format() : $"{arg1}",
                            arg2 is ITextual t2 ? t2.Format() : $"{arg2}",
                            arg3 is ITextual t3 ? t3.Format() : $"{arg3}"
                            );

        /// <summary>
        /// Formats a pattern using 5 parametric arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        /// <typeparam name="A">The first argument type</typeparam>
        /// <typeparam name="B">The second argument type</typeparam>
        /// <typeparam name="C">The third argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B,C,D,E>(string pattern, A arg0, B arg1, C arg2, D arg3, E arg4)
            => string.Format(pattern,
                            arg0 is ITextual t0 ? t0.Format() : $"{arg0}",
                            arg1 is ITextual t1 ? t1.Format() : $"{arg1}",
                            arg2 is ITextual t2 ? t2.Format() : $"{arg2}",
                            arg3 is ITextual t3 ? t3.Format() : $"{arg3}",
                            arg4 is ITextual t4 ? t4.Format() : $"{arg4}"
                            );

        /// <summary>
        /// Formats a <see cref='ITextual'/>
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct, ITextual
                => src.Format();
    }
}