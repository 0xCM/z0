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

    partial class text
    {

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

        [MethodImpl(Inline)]
        public static string format(string pattern, params object[] args)
            => Format.format(pattern, args);

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

        [MethodImpl(Inline)]
        public static string format<A,B,C,D,E,F,G>(string pattern, A a, B b, C c, D d, E e, F f, G g)
            => Format.format(pattern, a, b, c, d, e, f, g);

        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct, ITextual
                => src.Format();
    }
}