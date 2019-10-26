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
    
    using static zfunc;

    public static class ArithExprEval
    {
        public static TypedLiteralExpr<T> eval<T>(IArithmeticExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ITypedLiteral<T> x:
                    return x.Value;
                case IVarExpr<T> x:
                    return eval(x);
                case IArithmeticOp<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        [MethodImpl(Inline)]
        static TypedLiteralExpr<T> eval<T>(ITypedExpr<T> a)
            where T : unmanaged
                => ScalarExprEval.eval(a);

        static TypedLiteralExpr<T> eval<T>(IVarExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Value)
            {
                case ITypedLiteral<T> x:
                    return x.Value;
                case IArithmeticExpr<T> x:
                    return eval(x);
                default:
                    return eval(expr.Value);
                
            }
        }


        static TypedLiteralExpr<T> eval<T>(IArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryArithmeticOp<T> x:
                    return eval(x);
                case IBinaryArithmeticOp<T> x:
                    return eval(x);
                case IComparisonExpr<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        static TypedLiteralExpr<T> eval<T>(IUnaryArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)               
            {
                case UnaryArithmeticOpKind.Inc: return inc(expr);
                case UnaryArithmeticOpKind.Dec: return dec(expr);
                case UnaryArithmeticOpKind.Negate: return negate(expr);
                default: return unhandled(expr);
            }
        }

        static TypedLiteralExpr<T> eval<T>(IBinaryArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)
            {
                case BinaryArithmeticOpKind.Add: return add(expr);
                case BinaryArithmeticOpKind.Sub: return sub(expr);
                default: return unhandled(expr);
            }
        }

        static TypedLiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)               
            {
                case ComparisonOpKind.Eq: return cmpeq(expr);
                case ComparisonOpKind.Lt: return lt(expr);
                case ComparisonOpKind.LtEq: return lteq(expr);
                case ComparisonOpKind.Gt: return gt(expr);
                case ComparisonOpKind.GtEq: return gteq(expr);
                default: return unhandled(expr);
            }
        }

        static TypedLiteralExpr<T> inc<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => ScalarOps.inc(eval(a).Value);

        static TypedLiteralExpr<T> dec<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => ScalarOps.dec(eval(a).Value);

        static TypedLiteralExpr<T> negate<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => ScalarOps.negate(eval(a).Value);
    
        static TypedLiteralExpr<T> add<T>(IBinaryArithmeticOp<T> expr)
            where T : unmanaged
                => ScalarOps.add(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static TypedLiteralExpr<T> sub<T>(IBinaryArithmeticOp<T> expr)
            where T : unmanaged
                => ScalarOps.sub(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static TypedLiteralExpr<T> cmpeq<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOps.eq(eval(expr.LeftArg).Value, eval(expr.RightArg).Value).As<T>();

        static TypedLiteralExpr<T> lt<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOps.lt(eval(expr.LeftArg).Value, eval(expr.RightArg).Value).As<T>();

        static TypedLiteralExpr<T> lteq<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOps.lteq(eval(expr.LeftArg).Value, eval(expr.RightArg).Value).As<T>();

        static TypedLiteralExpr<T> gt<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOps.gt(eval(expr.LeftArg).Value, eval(expr.RightArg).Value).As<T>();

        static TypedLiteralExpr<T> gteq<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOps.gteq(ScalarExprEval.eval(expr.LeftArg).Value, ScalarExprEval.eval(expr.RightArg).Value).As<T>();

        static TypedLiteralExpr<T> unhandled<T>(ITypedExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");
    }

}


