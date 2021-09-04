//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct LE<T> : ICmpPred<LE<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public LE(T a, T b)
            {
                A = a;
                B = b;
            }

            public string Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbol.LE;
            }

            public CmpKind Kind
                => CmpKind.LE;

            [MethodImpl(Inline)]
            public string Format()
                => format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator LE<T>((T a, T b) src)
                => new LE<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(LE<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}