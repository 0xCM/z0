//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;
    using static RP;

    partial class text
    {
        [Op, Closures(Closure)]
        public static string format<T>(PropFormat<T> src, char sep = RP.PropertySep)
            => string.Format("{0}{1}{2}",
                string.Format(RP.pad(src.Pad), src.Name),
                string.Format("{0} ",sep),
                    src.Value);

        [Op]
        public static string format(PropFormat src, char sep = RP.PropertySep)
            => string.Format("{0}{1}{2}",
                string.Format(RP.pad(src.Pad), src.Name),
                string.Format("{0} ", sep),
                    src.Value);

        [MethodImpl(Inline)]
        static string msgarg<T>(T src)
            => string.Format("<{0}>", src);

        public static string msg<T>(string pattern, T a)
            => Format.format(pattern, msgarg(a));

        public static string msg<A,B>(string pattern, A a, B b)
            => Format.format(pattern, msgarg(a), msgarg(b));

        public static string msg<A,B,C>(string pattern, A a, B b, C c)
            => Format.format(pattern, msgarg(a), msgarg(b), msgarg(c));

        public static string msg<A,B,C,D>(string pattern, A a, B b, C c, D d)
            => Format.format(pattern, msgarg(a), msgarg(b), msgarg(c), msgarg(d));

        public static string msg<A,B,C,D,E>(string pattern, A a, B b, C c, D d, E e)
            => Format.format(pattern, msgarg(a), msgarg(b), msgarg(c), msgarg(d), msgarg(e));

        public static string msg<A,B,C,D,E,F>(string pattern, A a, B b, C c, D d, E e, F f)
            => Format.format(pattern, msgarg(a), msgarg(b), msgarg(c), msgarg(d), msgarg(e), msgarg(f));

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> src)
            => Format.format(src);

        [MethodImpl(Inline), Op]
        public static string format(string pattern, ReadOnlySpan<char> a0)
            => Format.format(pattern, a0);

        [MethodImpl(Inline), Op]
        public static string format(string pattern, ReadOnlySpan<char> a0, ReadOnlySpan<char> a1)
            => Format.format(pattern, a0, a1);

        [MethodImpl(Inline), Op]
        public static string format(string pattern, ReadOnlySpan<char> a0, ReadOnlySpan<char> a1, ReadOnlySpan<char> a2)
            => Format.format(pattern, a0, a1, a2);

        [Op]
        public static string format(string pattern, params object[] args)
            => string.Format(pattern, args);

        [MethodImpl(Inline)]
        public static string format(object src)
            => Format.format(src);

        [MethodImpl(Inline)]
        public static string format(object src, Type t, char delimiter, RenderWidth width)
            => Format.format(src, t, delimiter, width);

        [MethodImpl(Inline)]
        public static string format<T>(string pattern, T a)
            => Format.format(pattern, a);

        [MethodImpl(Inline)]
        public static string format<A,B>(string pattern, A a, B b)
            => Format.format(pattern, a, b);

        [MethodImpl(Inline)]
        public static string format<A,B,C>(string pattern, A a, B b, C c)
            => Format.format(pattern, a, b, c);

        [MethodImpl(Inline)]
        public static string format<A,B,C,D>(string pattern, A a, B b, C c, D d)
            => Format.format(pattern, a, b, c, d);

        [MethodImpl(Inline)]
        public static string format<A,B,C,D,E>(string pattern, A a, B b, C c, D d, E e)
            => Format.format(pattern, a, b, c, d, e);

        [MethodImpl(Inline)]
        public static string format<A,B,C,D,E,F>(string pattern, A a, B b, C c, D d, E e, F f)
            => Format.format(pattern, a, b, c, d, e, f);

        /// <summary>
        /// Renders a septet of values according to a format pattern
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
        public static string format<A,B,C,D,E,F,G>(string pattern, A a, B b, C c, D d, E e, F f, G g)
            => string.Format(pattern,
                            a is ITextual t0 ? t0.Format() : $"{a}",
                            b is ITextual t1 ? t1.Format() : $"{b}",
                            c is ITextual t2 ? t2.Format() : $"{c}",
                            d is ITextual t3 ? t3.Format() : $"{d}",
                            e is ITextual t4 ? t4.Format() : $"{e}",
                            f is ITextual t5 ? t5.Format() : $"{f}",
                            g is ITextual t6 ? t6.Format() : $"{g}"
                            );
        /// <summary>
        /// Renders an octet of values according to a format pattern
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
        public static string format<A,B,C,D,E,F,G,H>(string pattern, A a, B b, C c, D d, E e, F f, G g, H h)
            => string.Format(pattern,
                            a is ITextual t0 ? t0.Format() : $"{a}",
                            b is ITextual t1 ? t1.Format() : $"{b}",
                            c is ITextual t2 ? t2.Format() : $"{c}",
                            d is ITextual t3 ? t3.Format() : $"{d}",
                            e is ITextual t4 ? t4.Format() : $"{e}",
                            f is ITextual t5 ? t5.Format() : $"{f}",
                            g is ITextual t6 ? t6.Format() : $"{g}",
                            h is ITextual t7 ? t7.Format() : $"{h}"
                            );

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

    }
}