//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using static Functions;

    public readonly partial struct BitwiseOperators
    {
        public sealed class Xor<T> : BinaryOperator<T>
            where T : unmanaged
        {
            public override T Eval(T a, T b)
                => gmath.xor(a,b);
        }

        public sealed class Or<T> : BinaryOperator<T>
            where T : unmanaged
        {
            public override T Eval(T a, T b)
                => gmath.or(a,b);
        }

        public sealed class And<T> : BinaryOperator<T>
            where T : unmanaged
        {
            public override T Eval(T a, T b)
                => gmath.or(a,b);
        }
    }
}