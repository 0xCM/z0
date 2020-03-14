//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    //[ApiHost("expr.vector.eval", ApiHostKind.Generic)]
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
                case IOperatorExpr<Vector128<T>> x:
                    return eval(x);
                case IComparisonExpr<Vector128<T>> x:
                    return gvec.vxnor(eval(x.LeftArg).Value, eval(x.RightArg).Value);
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
                case IOperatorExpr<Vector256<T>> x:
                    return eval(x);
                case IComparisonExpr<Vector256<T>> x:
                    return gvec.vxnor(eval(x.LeftArg).Value, eval(x.RightArg).Value);
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

        [Op("eval_vec128_op"), NumericClosures(NumericKind.Integers)]
        static LiteralExpr<Vector128<T>> eval<T>(IOperatorExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOpExpr<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOpExpr<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOpExpr<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Subject).Value, ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOpExpr<Vector128<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

       [Op("eval_vec256_op"), NumericClosures(NumericKind.Integers)]
       static LiteralExpr<Vector256<T>> eval<T>(IOperatorExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitwiseOpExpr<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Arg).Value);
                case IBinaryBitwiseOpExpr<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.LeftArg).Value, eval(x.RightArg).Value);
                case IShiftOpExpr<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.Subject).Value, ScalarExprEval.eval(x.Offset).Value);
                case ITernaryBitwiseOpExpr<Vector256<T>> x:
                    return VectorOpApi.eval(x.OpKind, eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.ThirdArg));
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        } 
    }
}