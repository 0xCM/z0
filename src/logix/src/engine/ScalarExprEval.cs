//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

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
                case IOperatorExpr<T> x:
                    return eval(x);
                case IComparisonExpr<T> x:
                    return gmath.xnor(eval(x.LeftArg).Value, eval(x.RightArg).Value);
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

        static LiteralExpr<T> eval<T>(IOperatorExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOpExpr<T> x:
                    return NumericBits.eval(x.OpKind, eval(x.Arg).Value);

                case IBinaryBitwiseOpExpr<T> x:
                    return NumericBits.eval(x.OpKind, 
                        eval(x.LeftArg).Value, eval(x.RightArg).Value);

                case IShiftOpExpr<T> x:
                    return NumericBits.eval(x.OpKind, 
                        eval(x.Subject).Value, eval(x.Offset).Value);

                case ITernaryBitwiseOpExpr<T> x:
                    return NumericBits.eval(x.OpKind, 
                        eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.SecondArg).Value);
                        
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }
    }
}