//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
         public static LiteralExpr<Vector128<T>> eval<T>(IExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteralExpr<Vector128<T>> x:
                    return x.Value;
                case IVarExpr<Vector128<T>> x:
                    return eval(x.Value);
                case IVariedExpr<Vector128<T>> x:
                    return eval(x.BaseExpr);
                case IOperator<Vector128<T>> x:
                    return eval(x);
                case IComparisonExpr<Vector128<T>> x:
                    return ginx.vxnor(eval(x.LeftArg).Value, eval(x.RightArg).Value);
                default:
                    return unhandled(expr);
            }

        }

        public static LiteralExpr<Vector256<T>> eval<T>(IExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteralExpr<Vector256<T>> x:
                    return x.Value;
                case IVarExpr<Vector256<T>> x:
                    return eval(x.Value);
                case IVariedExpr<Vector256<T>> x:
                    return eval(x.BaseExpr);
                case IOperator<Vector256<T>> x:
                    return eval(x);
                case IComparisonExpr<Vector256<T>> x:
                    return ginx.vxnor(eval(x.LeftArg).Value, eval(x.RightArg).Value);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<Vector128<T>> eval<T>(IOperator<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<Vector128<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector128<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector128<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.Subject).Value, (byte)ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOp<Vector128<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<Vector256<T>> eval<T>(IOperator<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<Vector256<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector256<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector256<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.Subject).Value, (byte)ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOp<Vector256<T>> x:
                    return CpuOpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }
 
        static LiteralExpr<Vector128<T>> unhandled<T>(IExpr<Vector128<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");

        static LiteralExpr<Vector256<T>> unhandled<T>(IExpr<Vector256<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");
    }
}