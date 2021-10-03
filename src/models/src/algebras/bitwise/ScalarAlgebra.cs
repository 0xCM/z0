//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct BitwiseAlgebras
    {
        public readonly struct ScalarAlgebra<T> : IBooleanAlgebra<ScalarAlgebra<T>>
            where T : unmanaged
        {
            readonly T Value;

            [MethodImpl(Inline)]
            public ScalarAlgebra(T value)
            {
                Value = value;
            }

            [MethodImpl(Inline)]
            public ScalarAlgebra<T> And(ScalarAlgebra<T> a)
                => gmath.and(Value,a.Value);

            [MethodImpl(Inline)]
            public ScalarAlgebra<T> Or(ScalarAlgebra<T> a)
                => gmath.or(Value,a.Value);

            [MethodImpl(Inline)]
            public ScalarAlgebra<T> Not()
                => gmath.not(Value);

            [MethodImpl(Inline)]
            public static ScalarAlgebra<T> operator &(ScalarAlgebra<T> a, ScalarAlgebra<T> b)
                => a.And(b);

            [MethodImpl(Inline)]
            public static ScalarAlgebra<T> operator |(ScalarAlgebra<T> a, ScalarAlgebra<T> b)
                => a.Or(b);

            [MethodImpl(Inline)]
            public static ScalarAlgebra<T> operator ~(ScalarAlgebra<T> a)
                => a.Not();

            [MethodImpl(Inline)]
            public static implicit operator ScalarAlgebra<T>(T src)
                => new ScalarAlgebra<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator T(ScalarAlgebra<T> src)
                => src.Value;
        }
    }
}