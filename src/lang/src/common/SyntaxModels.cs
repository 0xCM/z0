//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.SyntaxModels, true)]
    public readonly partial struct SyntaxModels
    {
        const string FencePattern = "<<{0}..{1}>>";

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FenceSyntax<T> fence<T>(T left, T right)
            where T : unmanaged
                => new FenceSyntax<T>(left,right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Label<T> label<T>(T src)
            => new Label<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Identifier<T> identifier<T>(T src)
            => new Identifier<T>(src);

        [MethodImpl(Inline), Op]
        public static Identifier<Name> identifier(string src)
            => new Identifier<Name>(src);

        [MethodImpl(Inline)]
        public static Literal<I,T> literal<I,T>(I id, T value)
            => new Literal<I,T>(id,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<Name,T> literal<T>(string id, T value)
            => new Literal<Name,T>(identifier(id), value);

        [Op, Closures(Closure)]
        public static string format<T>(FenceSyntax<T> src)
            => string.Format(FencePattern, src.Left, src.Right);

        [MethodImpl(Inline)]
        static string format<A,B>(string pattern, A a, B b)
            => string.Format(pattern, a, b);
    }
}