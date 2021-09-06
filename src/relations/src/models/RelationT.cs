//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a correspondence between two elements
    /// </summary>
    public readonly struct Relation<T>
    {
        public readonly T A;

        public readonly T B;

        [MethodImpl(Inline)]
        public Relation(T a, T b)
        {
            A = a;
            B = b;
        }

        public void Deconstruct(out T a, out T b)
        {
            a = A;
            b = B;
        }

        [MethodImpl(Inline)]
        public static implicit operator Relation<T>((T a, T b) x)
            => new Relation<T>(x.a, x.b);

        [MethodImpl(Inline)]
        public static implicit operator Relation<T>(Relation<T,T> src)
            => new Relation<T>(src.A, src.B);
    }
}