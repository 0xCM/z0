//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    static class ScalarExprEval
    {
        public static LiteralExpr<T> eval<T>(ITypedExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ITypedLiteral<T> x:
                    return x.Value;
                case IVariedExpr<T> x:
                    return eval(x.BaseExpr);
                case IVarExpr<T> x:
                    return eval(x.Value);
                case IOpExpr<T> x:
                    return eval(x);
                case IEqualityExpr<T> x:
                    return gmath.xnor(eval(x.Lhs).Value, eval(x.Rhs).Value);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<T> eval<T>(IOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, eval(x.Arg).Value);

                case IBinaryBitwiseOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, 
                        eval(x.LeftArg).Value, eval(x.RightArg).Value);

                case IShiftOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, 
                        eval(x.Subject).Value, eval(x.Offset).Value);

                case ITernaryOp<T> x:
                    return ScalarOpApi.eval(x.OpKind, 
                        eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.SecondArg).Value);
                        
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<T> unhandled<T>(ITypedExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");
    }

}