//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    [ApiHost]
    public readonly struct ScalarExprEval
    {
        [Op, Closures(UnsignedInts)]
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

        [Op, Closures(UnsignedInts)]
        static LiteralExpr<T> eval<T>(IOperatorExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IUnaryBitwiseOpExpr<T> x:
                    return NumericLogixHost.eval(x.ApiClass, eval(x.Arg).Value);

                case IBinaryBitwiseOpExpr<T> x:
                    return NumericLogixHost.eval(x.ApiClass,
                        eval(x.LeftArg).Value, eval(x.RightArg).Value);

                case IShiftOpExpr<T> x:
                    return NumericLogixHost.eval(x.ApiClass,
                        eval(x.Subject).Value, eval(x.Offset).Value);

                case ITernaryBitwiseOpExpr<T> x:
                    return NumericLogixHost.eval(x.ApiClass,
                        eval(x.FirstArg).Value, eval(x.SecondArg).Value, eval(x.SecondArg).Value);

                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }
    }
}