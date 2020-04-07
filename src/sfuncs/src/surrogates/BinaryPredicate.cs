//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Surrogates
    {
        public readonly struct BinaryPredicate<T> : ISFuncApi<T,T,bit>
        {
            public OpIdentity Id {get;}

            readonly Z0.BinaryPredicate<T> F;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T,bit>(BinaryPredicate<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            internal BinaryPredicate(Z0.BinaryPredicate<T> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }

            [MethodImpl(Inline)]
            internal BinaryPredicate(Z0.BinaryPredicate<T> f, string name)            
            {
                this.F = f;
                this.Id = Identify.sFunc<T>(name);
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