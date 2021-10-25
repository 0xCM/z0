//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct EvalCapture : IEvalCapture
    {
        public IExpr Input {get;}

        public IExpr Output {get;}

        [MethodImpl(Inline)]
        public EvalCapture(IExpr input, IExpr output)
        {
            Input = input;
            Output = output;
        }
    }
}