//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Eval
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct ExprEvalCapture : IEvalCapture
    {
        public IExpr Input {get;}

        public IExpr Output {get;}

        [MethodImpl(Inline)]
        public ExprEvalCapture(IExpr input, IExpr output)
        {
            Input = input;
            Output = output;
        }
    }
}