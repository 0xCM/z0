//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TextExpr : ITextExpr<TextExpr>
    {
        public Type ExprType {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public TextExpr(Type type, string src)
        {
            Content = src ?? EmptyString;
            ExprType = type;
        }
    }

    public readonly struct TextExpr<T> : ITextExpr<TextExpr<T>>
        where T : struct, ITextExpr<T>
    {
        public T Source {get;}

        public Type ExprType => typeof(T);

        public string Content
        {
            [MethodImpl(Inline)]
            get => Source.Content;
        }

        [MethodImpl(Inline)]
        public TextExpr(T src)
        {
            Source = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator TextExpr<T>(T src)
            => new TextExpr<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator TextExpr(TextExpr<T> src)
            => new TextExpr(src.ExprType, src.Content);
    }
}