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

    using static Root;
    using static RP;

    partial struct TextFormatter
    {
        /// <summary>
        /// Formats the pair of strings represented by respective character spans
        /// </summary>
        /// <param name="a">The leading content</param>
        /// <param name="b">The trailing content</param>
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
            => string.Concat(a,b);

        /// <summary>
        /// Renders a k/v pair as a setting
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        [MethodImpl(Inline), Op]
        public static string setting<K,V>(K key, V value)
            => string.Format(RP.Setting, key, value);

        /// <summary>
        /// Renders a variable assignment as '<paramref name='name'/>=</paramref name='value'/>;
        /// </summary>
        /// <param name="name">The variable name</param>
        /// <param name="value">The varable value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op]
        public static string assign<T>(Name name, T value)
            => string.Format(RP.Assign, name, value);

        /// <summary>
        /// Formats the pair of strings represented by respective character spans
        /// </summary>
        /// <param name="a">The leading content</param>
        /// <param name="b">The trailing content</param>
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> a)
            => a.ToString();

        [MethodImpl(Inline), Op]
        static string format(string src)
            => src ?? EmptyString;

        /// <summary>
        /// Formats three operands according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first operand</param>
        /// <param name="arg1">The second operand</param>
        /// <param name="arg2">The third operand</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, string arg0, string arg1, string arg2)
            => string.Format(format(pattern), format(arg0), format(arg1), format(arg2));

        /// <summary>
        /// Formats a source operand according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The source operand</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, string arg0)
            => string.Format(pattern, format(arg0));

        /// <summary>
        /// Formats two operands according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first operand</param>
        /// <param name="arg1">The second operand</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, string arg0, string arg1)
            => string.Format(pattern, format(arg0), format(arg1));

        /// <summary>
        /// Renders a pair of <see cref='ITextual'/> values as pipe-delimited text
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <typeparam name="A">The first value type</typeparam>
        /// <typeparam name="B">The second value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B>(A a, B b)
            where A : ITextual
            where B : ITextual
                => string.Format(PSx2, a.Format(),  b.Format());

        /// <summary>
        /// Renders a triple of <see cref='ITextual'/> values as pipe-delimited text
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <param name="c">The third value</param>
        /// <typeparam name="A">The first value type</typeparam>
        /// <typeparam name="B">The second value type</typeparam>
        /// <typeparam name="C">The third value type</typeparam>
        public static string format<A,B,C>(A a, B b, C c)
            where A : ITextual
            where B : ITextual
            where C : ITextual
                => string.Format(PSx3, a.Format(), b.Format(), c.Format());

        /// <summary>
        /// Renders a quartet of <see cref='ITextual'/> values as pipe-delimited text
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <param name="c">The third value</param>
        /// <param name="d">The fourth value</param>
        /// <typeparam name="A">The first value type</typeparam>
        /// <typeparam name="B">The second value type</typeparam>
        /// <typeparam name="C">The third value type</typeparam>
        /// <typeparam name="D">The fourth value type</typeparam>
        public static string format<A,B,C,D>(A a, B b, C c, D d)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
                => string.Format(PSx4, a.Format(), b.Format(), c.Format(), d.Format());

        /// <summary>
        /// Renders a quintet of <see cref='ITextual'/> values as pipe-delimited text
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <param name="c">The third value</param>
        /// <param name="d">The fourth value</param>
        /// <param name="e">The fifth value</param>
        /// <typeparam name="A">The first value type</typeparam>
        /// <typeparam name="B">The second value type</typeparam>
        /// <typeparam name="C">The third value type</typeparam>
        /// <typeparam name="D">The fourth value type</typeparam>
        /// <typeparam name="E">The fifth value type</typeparam>
        public static string format<A,B,C,D,E>(A a, B b, C c, D d, E e)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
                => string.Format(PSx5, a.Format(), b.Format(), c.Format(), d.Format(), e.Format());

        /// <summary>
        /// Renders a sextet of <see cref='ITextual'/> values as pipe-delimited text
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
        public static string format<A,B,C,D,E,F>(A a, B b, C c, D d, E e, F f)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
            where F : ITextual
                => string.Format(PSx6, a.Format(), b.Format(), c.Format(), d.Format(), e.Format(), f.Format());

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
        public static string format<A,B,C,D,E,F,G>(A a, B b, C c, D d, E e, F f, G g)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
            where F : ITextual
            where G : ITextual
                => string.Format(PSx6, a.Format(), b.Format(), c.Format(), d.Format(), e.Format(), f.Format(), g.Format());

        /// <summary>
        /// Formats each <see cref='ITextual'/> in the source
        /// </summary>
        /// <param name="items">The source stream</param>
        /// <typeparam name="F">The element type</typeparam>
        public static IEnumerable<string> format<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());
    }
}