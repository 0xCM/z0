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
    using static OpHelpers;

    [ApiHost("expr.vector.eval")]
    static class VectorExprEval
    {
        [Op("eval_vec128_expr"), NumericClosures(NumericKind.Integers)]
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
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

        [Op("eval_vec256_expr"), NumericClosures(NumericKind.Integers)]
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
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

        [Op("eval_vec128_op"), NumericClosures(NumericKind.Integers)]
        static LiteralExpr<Vector128<T>> eval<T>(IOperator<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Subject).Value, ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOp<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

       [Op("eval_vec256_op"), NumericClosures(NumericKind.Integers)]
       static LiteralExpr<Vector256<T>> eval<T>(IOperator<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOp<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOp<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOp<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Subject).Value, ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOp<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }
 
    }
}