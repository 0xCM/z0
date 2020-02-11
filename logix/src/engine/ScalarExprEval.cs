//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    [ApiHost("expr.scalar.eval")]
    static class ScalarExprEval
    {
        public static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteralExpr<T> x:
                    return x.Value;
                case IVariedExpr<T> x:
                    return eval(x.BaseExpr);
                case IVarExpr<T> x:
                    return eval(x.Value);
                case IOperator<T> x:
                    return eval(x);
                case IComparisonExpr<T> x:
                    return gmath.xnor(eval(x.LeftArg).Value, eval(x.RightArg).Value);
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

        static LiteralExpr<T> eval<T>(IOperator<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, eval(x.Arg).Value);

                case IBinaryBitwiseOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, 
                        eval(x.LeftArg).Value, eval(x.RightArg).Value);

                case IShiftOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, 
                        eval(x.Subject).Value, eval(x.Offset).Value);

                case ITernaryBitwiseOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, 
                        eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.SecondArg).Value);
                        
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }
    }
}