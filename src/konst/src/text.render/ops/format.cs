//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static z;

    partial struct Render
    {
        /// <summary>
        /// Renders a source value as text
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(T src)
            => text.format(Slot0, src);

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
    }
}