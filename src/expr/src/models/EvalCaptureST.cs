//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public struct EvalCapture<S,T> : IEvalCapture<S,T>
        where S : IExpr
        where T : IExpr
    {
        public S Input {get;}

        public T Output {get;}

        [MethodImpl(Inline)]
        public EvalCapture(S input, T output)
        {
            Input = input;
            Output = output;
        }

        [MethodImpl(Inline)]
        public static implicit operator EvalCapture(EvalCapture<S,T> src)
            => new EvalCapture(src.Input, src.Output);

        [MethodImpl(Inline)]
        public static implicit operator EvalCapture<S,T>(Paired<S,T> src)
            => new EvalCapture<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator EvalCapture<S,T>((S input, T output) src)
            => new EvalCapture<S,T>(src.input, src.output);

    }
}