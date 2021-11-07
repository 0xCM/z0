//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Eval
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    public struct Evaluation<S,T> : IEvaluation<S,T>
        where S : IExpr
        where T : IExpr
    {
        public S Input {get;}

        public T Output {get;}

        [MethodImpl(Inline)]
        public Evaluation(S input, T output)
        {
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public static implicit operator Evaluation(Evaluation<S,T> src)
            => new Evaluation(src.Input, src.Output);

        [MethodImpl(Inline)]
        public static implicit operator Evaluation<S,T>(Paired<S,T> src)
            => new Evaluation<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Evaluation<S,T>((S input, T output) src)
            => new Evaluation<S,T>(src.input, src.output);
    }
}