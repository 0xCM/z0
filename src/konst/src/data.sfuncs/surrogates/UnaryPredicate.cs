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
        public readonly struct UnaryPredicate<T> : IFunc<T,Bit32>
        {
            public OpIdentity Id {get;}

            readonly Z0.UnaryPredicate<T> F;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,Bit32>(UnaryPredicate<T> src)
                => src.AsFunc();

            [MethodImpl(Inline)]
            internal UnaryPredicate(Z0.UnaryPredicate<T> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            [MethodImpl(Inline)]
            internal UnaryPredicate(Z0.UnaryPredicate<T> f, string name)
            {
                F = f;
                Id = ApiIdentify.sfunc<T>(name);
            }

            [MethodImpl(Inline)]
            public Bit32 Invoke(T a)
                => F(a);

            public Z0.UnaryPredicate<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,Bit32> AsFunc()
                 => SFx.surrogate(this);
        }
    }
}