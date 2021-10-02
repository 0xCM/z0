//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public readonly struct IfThen<P,T>
        {
            public readonly P Predicate;

            public readonly T Target;

            [MethodImpl(Inline)]
            public IfThen(P pred, T target)
            {
                Predicate = pred;
                Target = target;
            }

            [MethodImpl(Inline)]
            public static implicit operator IfThen<P,T>((P pred, T target) src)
                => new IfThen<P,T>(src.pred, src.target);
        }
    }
}