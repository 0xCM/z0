//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures an evaluation outcome
    /// </summary>
    public readonly struct EvalResult<T>
    {
        public EvalResult Outcome {get;}

        public T Transition {get;}

        [MethodImpl(Inline)]
        public EvalResult(EvalResult outcome, T transition)
        {
            Transition = transition;
            Outcome = outcome;
        }

        [MethodImpl(Inline)]
        public static implicit operator EvalResult(EvalResult<T> src)
            => src.Outcome;

        [MethodImpl(Inline)]
        public static implicit operator EvalResult<T>((EvalResult outcome, T transition) src)
            => new EvalResult<T>(src.outcome, src.transition);
    }
}