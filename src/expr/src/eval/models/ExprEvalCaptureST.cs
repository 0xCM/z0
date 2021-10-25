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

    public struct ExprEvalCapture<S,T> : IEvalCapture<S,T>
        where S : IExpr
        where T : IExpr
    {
        public S Input {get;}

        public T Output {get;}

        [MethodImpl(Inline)]
        public ExprEvalCapture(S input, T output)
        {
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public static implicit operator ExprEvalCapture(ExprEvalCapture<S,T> src)
            => new ExprEvalCapture(src.Input, src.Output);

        [MethodImpl(Inline)]
        public static implicit operator ExprEvalCapture<S,T>(Paired<S,T> src)
            => new ExprEvalCapture<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator ExprEvalCapture<S,T>((S input, T output) src)
            => new ExprEvalCapture<S,T>(src.input, src.output);

    }
}