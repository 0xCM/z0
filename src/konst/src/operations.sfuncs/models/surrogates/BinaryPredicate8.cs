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
        public readonly struct BinaryPredicate8<T> : IFunc<T,T,bool>
        {
            readonly Z0.BinaryPredicate8<T> F;

            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T,bool>(BinaryPredicate8<T> src)
                => src.AsFunc();

            [MethodImpl(Inline)]
            internal BinaryPredicate8(Z0.BinaryPredicate8<T> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            [MethodImpl(Inline)]
            internal BinaryPredicate8(Z0.BinaryPredicate8<T> f, string name)
            {
                F = f;
                Id = ApiIdentify.sfunc<T>(name);
            }

            [MethodImpl(Inline)]
            public bool Invoke(T a, T b)
                => F(a,b);

            public Z0.BinaryPredicate8<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,T,bool> AsFunc()
                => SFx.surrogate(this);
        }
    }
}