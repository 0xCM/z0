//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiCalls
    {
        public static ApiCall<A,B,C> result<A,B,C>(ApiClass @class, A a, B b, C c)
            => new ApiCall<A,B,C>(@class, a, b, c, string.Format("{0}({1},{2}) = {3}", @class.Format(), a, b, c));
    }

    public readonly struct ApiCall : ITextual
    {
        public ApiClass Class {get;}

        public TextBlock Expression {get;}

        [MethodImpl(Inline)]
        public ApiCall(ApiClass @class, TextBlock expression)
        {
            Class = @class;
            Expression = expression;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Expression;

        public override string ToString()
            => Format();
    }

    public readonly struct ApiCall<A,B,C> : ITextual
    {
        public ApiClass Class {get;}

        public TextBlock Expression {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        public C Result {get;}

        [MethodImpl(Inline)]
        public ApiCall(ApiClass @class, A a, B b, C c, TextBlock expression)
        {
            Class = @class;
            Arg0 = a;
            Arg1 = b;
            Result = c;
            Expression = expression;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Expression;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiCall(ApiCall<A,B,C> src)
            => new ApiCall(src.Class, src.Expression);
    }
}