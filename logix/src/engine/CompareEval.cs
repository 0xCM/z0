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

    public static class CompareEval
    {
        public static LiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        public static bit eval<T>(IComparisonPred<T> expr)
            where T : unmanaged
                => PredicateApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        public static LiteralExpr<Vector128<T>> eval<T>(IComparisonExpr<Vector128<T>> expr)
            where T : unmanaged
                => CpuOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);


        public static LiteralExpr<Vector256<T>> eval<T>(IComparisonExpr<Vector256<T>> expr)
            where T : unmanaged
                => CpuOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IArithmeticExpr<T> x: return ArithExprEval.eval(x);
                default: return LogicEngine.eval(expr);                
            }
        }

        static LiteralExpr<Vector128<T>> eval<T>(IExpr<Vector128<T>> expr)
            where T : unmanaged
                => LogicEngine.eval(expr);

        static LiteralExpr<Vector256<T>> eval<T>(IExpr<Vector256<T>> expr)
            where T : unmanaged
                => LogicEngine.eval(expr);

    }

}