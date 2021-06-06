//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static Rules;
    using static RP;

    partial class text
    {
        [Op]
        public static string @string(ReadOnlySpan<char> src)
            => format(core.bytes(src));

        /// <summary>
        /// Creates a string from a span, via UTF8 encoding
        /// </summary>
        /// <param name="src">The data source</param>
        [Op, Doc("https://github.com/microsoft/ClangSharp/blob/6355b742f73915a21d18f74227f5c504b75bd976/sources/ClangSharp/Internals/SpanExtensions.cs")]
        public static unsafe string format(ReadOnlySpan<byte> src)
        {
            if(src.IsEmpty)
                return EmptyString;

            fixed(byte* pSrc = src)
                return Encoding.UTF8.GetString(pSrc, src.Length);
        }

        /// <summary>
        /// Creates a string from a span, via a specified encoding
        /// </summary>
        /// <param name="src">The data source</param>
        public static unsafe string format(ReadOnlySpan<byte> src, Encoding encoding)
        {
            if(src.IsEmpty)
                return EmptyString;

            fixed(byte* pSrc = src)
                return encoding.GetString(pSrc, src.Length);
        }

        /// <summary>
        /// Creates a string from a span, via Unicode encoding
        /// </summary>
        /// <param name="src">The data source</param>
        [Op, Doc("https://github.com/microsoft/ClangSharp/blob/6355b742f73915a21d18f74227f5c504b75bd976/sources/ClangSharp/Internals/SpanExtensions.cs")]
        public static unsafe string format(ReadOnlySpan<ushort> src)
        {
            if(src.IsEmpty)
                return EmptyString;

            fixed(ushort* pSrc = src)
                return Encoding.Unicode.GetString((byte*)pSrc, src.Length * 2);
        }

        /// <summary>
        /// Creates a string from a span, via UTF32 encoding
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op, Doc("https://github.com/microsoft/ClangSharp/blob/6355b742f73915a21d18f74227f5c504b75bd976/sources/ClangSharp/Internals/SpanExtensions.cs")]
        public static unsafe string format(ReadOnlySpan<uint> src)
        {
            if(src.IsEmpty)
                return EmptyString;

            fixed(uint* pSrc = src)
                return Encoding.UTF32.GetString((byte*)pSrc, src.Length * 4);
        }

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
            => string.Format(pattern, msgarg(a));

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> src)
            => new string(src);

        [Op]
        public static string format(string pattern, ReadOnlySpan<char> a0)
            => string.Format(pattern, format(a0));

        [Op]
        public static string format(string pattern, ReadOnlySpan<char> a0, ReadOnlySpan<char> a1)
            => string.Format(pattern, format(a0), format(a1));

        [Op]
        public static string format(string pattern, ReadOnlySpan<char> a0, ReadOnlySpan<char> a1, ReadOnlySpan<char> a2)
            => string.Format(pattern, format(a0), format(a1), format(a2));

        [Op]
        public static string format(string pattern, params object[] args)
            => string.Format(pattern, args);

        public static string format<F,C>(Fenced<F,C> rule)
        {
            var buffer = text.buffer();
            render(rule,buffer);
            return buffer.Emit();
        }

        public static void render<F,C>(Fenced<F,C> rule, ITextBuffer dst)
            => dst.AppendFormat("{0}{1}{2}", rule.Fence.Left, rule.Content, rule.Fence.Right);

        [Op]
        public static string format(object src)
            => src is ITextual t ? t.Format() : src?.ToString() ?? "!!null!!";

        [Op]
        public static string format(object src, Type t, char delimiter, RenderWidth width)
            => rpad(format("{0} {1}", delimiter, format(src)), width);

        public static string format<T>(string pattern, T a)
            => string.Format(pattern, a is ITextual t ? t.Format() : $"{a}");

        public static string format<A,B>(string pattern, A a, B b)
            => string.Format(pattern,
                a is ITextual t0 ? t0.Format() : $"{a}",
                b is ITextual t1 ? t1.Format() : $"{b}"
                );

        public static string format<A,B,C>(string pattern, A a, B b, C c)
            => string.Format(pattern,
                            a is ITextual t0 ? t0.Format() : $"{a}",
                            b is ITextual t1 ? t1.Format() : $"{b}",
                            c is ITextual t2 ? t2.Format() : $"{c}"
                            );

        public static string format<A,B,C,D>(string pattern, A a, B b, C c, D d)
            => string.Format(pattern,
                            a is ITextual t0 ? t0.Format() : $"{a}",
                            b is ITextual t1 ? t1.Format() : $"{b}",
                            c is ITextual t2 ? t2.Format() : $"{c}",
                            d is ITextual t3 ? t3.Format() : $"{d}"
                            );

        public static string format<A,B,C,D,E>(string pattern, A a, B b, C c, D d, E e)
            => string.Format(pattern,
                            a is ITextual t0 ? t0.Format() : $"{a}",
                            b is ITextual t1 ? t1.Format() : $"{b}",
                            c is ITextual t2 ? t2.Format() : $"{c}",
                            d is ITextual t3 ? t3.Format() : $"{d}",
                            e is ITextual t4 ? t4.Format() : $"{e}"
                            );

        public static string format<A,B,C,D,E,F>(string pattern, A a, B b, C c, D d, E e, F f)
            => string.Format(pattern,
                            a is ITextual t0 ? t0.Format() : $"{a}",
                            b is ITextual t1 ? t1.Format() : $"{b}",
                            c is ITextual t2 ? t2.Format() : $"{c}",
                            d is ITextual t3 ? t3.Format() : $"{d}",
                            e is ITextual t4 ? t4.Format() : $"{e}",
                            f is ITextual t5 ? t5.Format() : $"{f}"
                            );

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

        public static string format<A,B>(A a, B b)
            where A : ITextual
            where B : ITextual
                => string.Format(PSx2, a.Format(),  b.Format());

        public static string format<A,B,C>(A a, B b, C c)
            where A : ITextual
            where B : ITextual
            where C : ITextual
                => string.Format(PSx3, a.Format(), b.Format(), c.Format());

        public static string format<A,B,C,D>(A a, B b, C c, D d)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
                => string.Format(PSx4, a.Format(), b.Format(), c.Format(), d.Format());

        public static string format<A,B,C,D,E>(A a, B b, C c, D d, E e)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
                => string.Format(PSx5, a.Format(), b.Format(), c.Format(), d.Format(), e.Format());

        public static string format<A,B,C,D,E,F>(A a, B b, C c, D d, E e, F f)
            where A : ITextual
            where B : ITextual
            where C : ITextual
            where D : ITextual
            where E : ITextual
            where F : ITextual
                => string.Format(PSx6, a.Format(), b.Format(), c.Format(), d.Format(), e.Format(), f.Format());

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