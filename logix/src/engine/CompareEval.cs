//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    [ApiHost("expr.cmp.eval", ApiHostKind.Generic)]
    public static class CmpExprEval
    {
        [Op("eval_cmp_expr"), NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        public static LiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op("eval_cmp_pred"), NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        public static bit eval<T>(IComparisonPred<T> expr)
            where T : unmanaged
                => PredicateApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op("eval_vcmp_expr128"), NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        public static LiteralExpr<Vector128<T>> eval<T>(IComparisonExpr<Vector128<T>> expr)
            where T : unmanaged
                => VectorOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op("eval_vcmp_expr256"), NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        public static LiteralExpr<Vector256<T>> eval<T>(IComparisonExpr<Vector256<T>> expr)
            where T : unmanaged
                => VectorOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IArithmeticExpr<T> x: return ArithExprEval.eval(x);
                default: return LogicEngine.eval(expr);                
            }
        }

        [NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        static LiteralExpr<Vector128<T>> eval<T>(IExpr<Vector128<T>> expr)
            where T : unmanaged
                => LogicEngine.eval(expr);

        [NumericClosures(NumericKind.Integers & ~NumericKind.U64)]
        static LiteralExpr<Vector256<T>> eval<T>(IExpr<Vector256<T>> expr)
            where T : unmanaged
                => LogicEngine.eval(expr);
    }

}