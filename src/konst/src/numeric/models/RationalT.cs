//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a datatype that represents a rational number
    /// </summary>
    public struct Rational<T> : IRational<Rational<T>,T>
    {
        public T Over;

        public T Under;

        [MethodImpl(Inline)]
        public Rational(T over, T under)
        {
            Over = over;
            Under = under;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format($"{Over}/{Under}");

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Rational<T>((T over, T under) src)
            => new Rational<T>(src.over, src.under);

        [MethodImpl(Inline)]
        public static implicit operator Rational<T>(Pair<T> src)
            => new Rational<T>(src.Left, src.Right);

        public static Rational<T> Undefined
            => default;

        public static Rational<T> Zero
            => (default(T), z.force<T>(1));

        T IRational<T>.Over
            => Over;

        T IRational<T>.Under
            => Under;
    }
}