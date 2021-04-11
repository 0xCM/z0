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
            /// <summary>
            /// Formats a <see cref='ITextual'/>
            /// </summary>
            /// <param name="src">The source element</param>
            /// <typeparam name="T">The element type</typeparam>
            [MethodImpl(Inline)]
            public static string format<T>(T src)
                where T : struct, ITextual
                    => src.Format();

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
            /// <param name="a">The first pattern argument</param>
            /// <param name="b">The second pattern argument</param>
            /// <param name="c">The third pattern argument</param>
            /// <typeparam name="A">The first argument type</typeparam>
            /// <typeparam name="B">The second argument type</typeparam>
            /// <typeparam name="C">The third argument type</typeparam>
            [MethodImpl(Inline)]
            public static string format<A,B,C,D,E>(string pattern, A a, B b, C c, D d, E e)
                => string.Format(pattern,
                                a is ITextual t0 ? t0.Format() : $"{a}",
                                b is ITextual t1 ? t1.Format() : $"{b}",
                                c is ITextual t2 ? t2.Format() : $"{c}",
                                d is ITextual t3 ? t3.Format() : $"{d}",
                                e is ITextual t4 ? t4.Format() : $"{e}"
                                );

            /// <summary>
            /// Renders a septet of <see cref='ITextual'/> values as pipe-delimited text
            /// </summary>
            /// <param name="a">The first value</param>
            /// <param name="b">The second value</param>
            /// <param name="c">The third value</param>
            /// <param name="d">The fourth value</param>
            /// <param name="e">The fifth value</param>
            /// <param name="f">The sixth value</param>
            /// <typeparam name="A">The first value type</typeparam>
            /// <typeparam name="B">The second value type</typeparam>
            /// <typeparam name="C">The third value type</typeparam>
            /// <typeparam name="D">The fourth value type</typeparam>
            /// <typeparam name="E">The fifth value type</typeparam>
            /// <typeparam name="F">The sixth value type</typeparam>
            /// <typeparam name="G">The seventh value type</typeparam>
            public static string format<A,B,C,D,E,F>(string pattern, A a, B b, C c, D d, E e, F f)
                => string.Format(pattern,
                                a is ITextual t0 ? t0.Format() : $"{a}",
                                b is ITextual t1 ? t1.Format() : $"{b}",
                                c is ITextual t2 ? t2.Format() : $"{c}",
                                d is ITextual t3 ? t3.Format() : $"{d}",
                                e is ITextual t4 ? t4.Format() : $"{e}",
                                f is ITextual t5 ? t5.Format() : $"{f}"
                                );

        }
    }
}