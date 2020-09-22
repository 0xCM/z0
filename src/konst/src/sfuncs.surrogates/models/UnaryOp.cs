//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Surrogates
    {
        public readonly struct UnaryOp<T> : IUnaryOp<T>
        {
            public OpIdentity Id {get;}

            readonly Z0.UnaryOp<T> F;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T>(UnaryOp<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            internal UnaryOp(Z0.UnaryOp<T> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            [MethodImpl(Inline)]
            internal UnaryOp(Z0.UnaryOp<T> f, string name)
            {
                F = f;
                Id = ApiIdentityKinds.sfunc<T>(name);
            }

            [MethodImpl(Inline)]
            public T Invoke(T a) => F(a);

            public Z0.UnaryOp<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,T> AsFunc()
                => this.ToFunc();
        }
    }
}