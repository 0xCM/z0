//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    static class VectorExprEval
    {
         public static LiteralExpr<Vector128<T>> eval<T>(ITypedExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ITypedLiteral<Vector128<T>> x:
                    return x.Value;
                case IVarExpr<Vector128<T>> x:
                    return eval(x.Value);
                case IVariedExpr<Vector128<T>> x:
                    return eval(x.BaseExpr);
                case IOpExpr<Vector128<T>> x:
                    return eval(x);
                case IEqualityExpr<Vector128<T>> x:
                    return ginx.vxnor(eval(x.Lhs).Value, eval(x.Rhs).Value);
                default:
                    return unhandled(expr);
            }

        }

        public static LiteralExpr<Vector256<T>> eval<T>(ITypedExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ITypedLiteral<Vector256<T>> x:
                    return x.Value;
                case IVarExpr<Vector256<T>> x:
                    return eval(x.Value);
                case IVariedExpr<Vector256<T>> x:
                    return eval(x.BaseExpr);
                case IOpExpr<Vector256<T>> x:
                    return eval(x);
                case IEqualityExpr<Vector256<T>> x:
                    return ginx.vxnor(eval(x.Lhs).Value, eval(x.Rhs).Value);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<Vector128<T>> eval<T>(IOpExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.Subject).Value, (byte)ScalarExprEval.eval(x.Offset).Value);
                case ITernaryOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<Vector256<T>> eval<T>(IOpExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.Subject).Value, (byte)ScalarExprEval.eval(x.Offset).Value);
                case ITernaryOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }
 
        static LiteralExpr<Vector128<T>> unhandled<T>(ITypedExpr<Vector128<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");

        static LiteralExpr<Vector256<T>> unhandled<T>(ITypedExpr<Vector256<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");
    }
}