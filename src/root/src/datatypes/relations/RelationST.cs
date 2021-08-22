//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a correspondence between two elements
    /// </summary>
    public readonly struct Relation<S,T>
    {
        public readonly S A;

        public readonly T B;

        [MethodImpl(Inline)]
        public Relation(S a, T b)
        {
            A = a;
            B = b;
        }

        public void Deconstruct(out S a, out T b)
        {
            a = A;
            b = B;
        }

        [MethodImpl(Inline)]
        public static implicit operator Relation<S,T>((S src, T dst) x)
            => new Relation<S,T>(x.src, x.dst);
    }
}