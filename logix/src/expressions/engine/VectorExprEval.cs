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
         public static TypedLiteralExpr<Vector128<T>> eval<T>(ITypedExpr<Vector128<T>> expr)
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
                case ITypedOpExpr<Vector128<T>> x:
                    return eval(x);
                case ITypedEqualityExpr<Vector128<T>> x:
                    return ginx.vxnor(eval(x.Lhs).Value, eval(x.Rhs).Value);
                default:
                    return unhandled(expr);
            }

        }

        public static TypedLiteralExpr<Vector256<T>> eval<T>(ITypedExpr<Vector256<T>> expr)
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
                case ITypedOpExpr<Vector256<T>> x:
                    return eval(x);
                case ITypedEqualityExpr<Vector256<T>> x:
                    return ginx.vxnor(eval(x.Lhs).Value, eval(x.Rhs).Value);
                default:
                    return unhandled(expr);
            }
        }

        static TypedLiteralExpr<Vector128<T>> eval<T>(ITypedOpExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.Subject).Value, (byte)ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOp<Vector128<T>> x:
                    return Cpu128OpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }

        static TypedLiteralExpr<Vector256<T>> eval<T>(ITypedOpExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.Subject).Value, (byte)ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOp<Vector256<T>> x:
                    return Cpu256OpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }
 
        static TypedLiteralExpr<Vector128<T>> unhandled<T>(ITypedExpr<Vector128<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");

        static TypedLiteralExpr<Vector256<T>> unhandled<T>(ITypedExpr<Vector256<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");
    }
}