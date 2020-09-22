//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class Surrogates
    {
        public readonly struct BinaryPredicate<T> : IFunc<T,T,bit>
        {
            readonly Z0.BinaryPredicate<T> F;

            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T,bit>(BinaryPredicate<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            internal BinaryPredicate(Z0.BinaryPredicate<T> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            [MethodImpl(Inline)]
            internal BinaryPredicate(Z0.BinaryPredicate<T> f, string name)
            {
                F = f;
                Id = ApiIdentity.sfunc<T>(name);
            }

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => F(a,b);

            public Z0.BinaryPredicate<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,T,bit> AsFunc()
                => this.ToFunc();
        }
    }
}