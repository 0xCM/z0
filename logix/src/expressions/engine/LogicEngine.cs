//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static partial class LogicEngine
    {

        [MethodImpl(Inline)]
        public static bit eval(ILogicExpr expr)
            => BitExprEval.eval(expr);

        [MethodImpl(Inline)]
        public static Literal<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
                => ScalarExprEval.eval(expr);

        [MethodImpl(Inline)]
        public static Literal<Vec128<T>> eval<T>(IExpr<Vec128<T>> expr)
            where T : unmanaged
                => VectorExprEval.eval(expr);

        [MethodImpl(Inline)]
        public static Literal<Vec256<T>> eval<T>(IExpr<Vec256<T>> expr)
            where T : unmanaged
                => VectorExprEval.eval(expr);
  }
}