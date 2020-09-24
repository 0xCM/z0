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

    using static Konst;
    using static RP;
    using static z;

    partial struct Render
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
        /// Formats the pair of strings represented by respective character spans
        /// </summary>
        /// <param name="a">The leading content</param>
        /// <param name="b">The trailing content</param>
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> a)
            => a.ToString();

        /// <summary>
        /// Formats a <see cref='StringRef'/>
        /// </summary>
        /// <param name="src">The source</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef src)
            => src.Format();

        /// <summary>
        /// Formats a source operand according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The source operand</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0)
            => string.Format(format(pattern), format(arg0));

        /// <summary>
        /// Formats two operands according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first operand</param>
        /// <param name="arg1">The second operand</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1)
            => string.Format(format(pattern), format(arg0), format(arg1));

        /// <summary>
        /// Formats three operands according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first operand</param>
        /// <param name="arg1">The second operand</param>
        /// <param name="arg2">The third operand</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1, in StringRef arg2)
            => string.Format(format(pattern), format(arg0), format(arg1), format(arg2));

        /// <summary>
        /// Formats a source operand according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The source operand</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in StringRef arg0)
            => string.Format(pattern, format(arg0));

        /// <summary>
        /// Formats two operands according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first operand</param>
        /// <param name="arg1">The second operand</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in StringRef arg0, in StringRef arg1)
            => string.Format(pattern, format(arg0), format(arg1));

        /// <summary>
        /// Formats three operands according to a specified pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first operand</param>
        /// <param name="arg1">The second operand</param>
        /// <param name="arg2">The third operand</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in StringRef arg0, in StringRef arg1, in StringRef arg2)
            => string.Format(pattern, format(arg0), format(arg1), format(arg2));

        /// <summary>
        /// Renders a source value as text
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(T src)
            => string.Format(Slot0, src);

        /// <summary>
        /// Renders a pair of <see cref='ITextual'/> values as <see cref='Pipe'/> delimited text
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
        /// Renders a triple of <see cref='ITextual'/> values as <see cref='Pipe'/> delimited text
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <param name="c">The third value</param>
        /// <typeparam name="A">The first value type</typeparam>
        /// <typeparam name="B">The second value type</typeparam>
        /// <typeparam name="C">The third value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B,C>(A a, B b, C c)
            where A : ITextual
            where B : ITextual
            where C : ITextual
                => string.Format(PSx3, a.Format(), b.Format(), c.Format());

        /// <summary>
        /// Renders a quartet of <see cref='ITextual'/> values as <see cref='Pipe'/> delimited text
        /// </summary>
        /// <param name="a">The first value</param>
        /// <param name="b">The second value</param>
        /// <param name="c">The third value</param>
        /// <param name="d">The fourth value</param>
        /// <typeparam name="A">The first value type</typeparam>
        /// <typeparam name="B">The second value type</typeparam>
        /// <typeparam name="C">The third value type</typeparam>
        /// <typeparam name="D">The fourth value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B,C,D>(A a, B b, C c, D d)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
                => string.Format(PSx4, a.Format(), b.Format(), c.Format(), d.Format());


        /// <summary>
        /// Renders a quintet of <see cref='ITextual'/> values as <see cref='Pipe'/> delimited text
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
        [MethodImpl(Inline)]
        public static string format<A,B,C,D,E>(A a, B b, C c, D d, E e)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
                => string.Format(PSx5, a.Format(), b.Format(), c.Format(), d.Format(), e.Format());

        /// <summary>
        /// Renders a sextet of <see cref='ITextual'/> values as <see cref='Pipe'/> delimited text
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
        [MethodImpl(Inline)]
        public static string format<A,B,C,D,E,F>(A a, B b, C c, D d, E e, F f)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
            where F : ITextual
                => string.Format(PSx5, a.Format(), b.Format(), c.Format(), d.Format(), e.Format(), f.Format());

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