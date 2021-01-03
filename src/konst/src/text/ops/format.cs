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
        public static string format<T>(T src)
            where T : struct, ITextual
                => src.Format();
    }
}