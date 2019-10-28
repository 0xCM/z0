//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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

    public static class CompareEval
    {
        public static TypedLiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        public static bit eval<T>(IComparisonPred<T> expr)
            where T : unmanaged
                => PredicateApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        public static TypedLiteralExpr<Vector128<T>> eval<T>(IComparisonExpr<Vector128<T>> expr)
            where T : unmanaged
                => CpuOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);


        public static TypedLiteralExpr<Vector256<T>> eval<T>(IComparisonExpr<Vector256<T>> expr)
            where T : unmanaged
                => CpuOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static TypedLiteralExpr<T> eval<T>(ITypedExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IArithmeticExpr<T> x: return ArithExprEval.eval(x);
                default: return LogicEngine.eval(expr);                
            }
        }

        static TypedLiteralExpr<Vector128<T>> eval<T>(ITypedExpr<Vector128<T>> expr)
            where T : unmanaged
                => LogicEngine.eval(expr);

        static TypedLiteralExpr<Vector256<T>> eval<T>(ITypedExpr<Vector256<T>> expr)
            where T : unmanaged
                => LogicEngine.eval(expr);

    }

}