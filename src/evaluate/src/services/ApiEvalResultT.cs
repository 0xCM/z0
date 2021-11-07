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
    /// Captures an evaluation outcome
    /// </summary>
    public readonly struct ApiEvalResult<T>
    {
        public ApiEvalResult Outcome {get;}

        public T Transition {get;}

        [MethodImpl(Inline)]
        public ApiEvalResult(ApiEvalResult outcome, T transition)
        {
            Transition = transition;
            Outcome = outcome;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiEvalResult(ApiEvalResult<T> src)
            => src.Outcome;

        [MethodImpl(Inline)]
        public static implicit operator ApiEvalResult<T>((ApiEvalResult outcome, T transition) src)
            => new ApiEvalResult<T>(src.outcome, src.transition);
    }
}