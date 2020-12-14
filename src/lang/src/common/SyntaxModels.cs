//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.SyntaxModels, true)]
    public readonly partial struct SyntaxModels
    {
        const string FencePattern = "<<{0}..{1}>>";

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static SyntaxFence fence(char left, char right)
            => new SyntaxFence(left,right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SyntaxFence<T> fence<T>(T left, T right)
            where T : unmanaged
                => new SyntaxFence<T>(left,right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Label<T> label<T>(T src)
            => new Label<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Identifier<T> identifier<T>(T src)
            => new Identifier<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Identifier<StringRef> identifier(string src)
            => new Identifier<StringRef>(src);

        [MethodImpl(Inline)]
        public static Literal<I,T> literal<I,T>(I id, T value)
            => new Literal<I,T>(id,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<StringRef,T> literal<T>(string id, T value)
            => new Literal<StringRef,T>(identifier(id), value);
        [Op]
        public static string format(SyntaxFence src)
            => string.Format(FencePattern, src.Left, src.Right);

        [Op, Closures(UnsignedInts)]
        public static string format<T>(SyntaxFence<T> src)
            where T : unmanaged
                => string.Format(FencePattern, src.Left, src.Right);
        [Op]
        public static string format(in SyntaxFence src)
            => format(FencePattern, src.Left, src.Right);

        [MethodImpl(Inline)]
        static string format<A,B>(string pattern, A a, B b)
            => string.Format(pattern, a, b);
    }
}