//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct EvalResult<T>
    {
        public readonly EvalResult Outcome;

        public readonly T Transition;

        [MethodImpl(Inline)]
        public static implicit operator EvalResult(EvalResult<T> src)
            => src.Outcome;

        [MethodImpl(Inline)]
        public static implicit operator EvalResult<T>((EvalResult outcome, T transition) src)
            => new EvalResult<T>(src.outcome, src.transition);

        [MethodImpl(Inline)]
        public EvalResult(EvalResult outcome, T transition)
        {
            Transition = transition;
            Outcome = outcome;
        }
    }
}