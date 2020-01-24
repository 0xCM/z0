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
    
    using static zfunc;

    public static class ArithExprEval
    {
        public static LiteralExpr<T> eval<T>(IArithmeticExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteralExpr<T> x:
                    return x.Value;
                case IVarExpr<T> x:
                    return eval(x);
                case IArithmeticOp<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IArithmeticExpr<T> x: return eval(x);
                default: return LogicEngine.eval(expr);                
            }
        }

        static LiteralExpr<T> eval<T>(IVarExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Value)
            {
                case ILiteralExpr<T> x:
                    return x.Value;
                default:
                    return eval(expr.Value);                
            }
        }

        static LiteralExpr<T> eval<T>(IArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryArithmeticOp<T> x:
                    return eval(x);
                case IBinaryArithmeticOp<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<T> eval<T>(IUnaryArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)               
            {
                case UnaryArithmeticKind.Inc: return inc(expr);
                case UnaryArithmeticKind.Dec: return dec(expr);
                case UnaryArithmeticKind.Negate: return negate(expr);
                default: return unhandled(expr);
            }
        }

        static LiteralExpr<T> eval<T>(IBinaryArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IComparisonExpr<T> x:
                    return eval(x);
                default:
                    switch(expr.OpKind)
                    {
                        case BinaryArithmeticKind.Add: return add(expr);
                        case BinaryArithmeticKind.Sub: return sub(expr);
                        default: return unhandled(expr);
                    }
            }
        }

        static LiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => ScalarOpApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static LiteralExpr<T> inc<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => ScalarOps.inc(eval(a).Value);

        static LiteralExpr<T> dec<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => ScalarOps.dec(eval(a).Value);

        static LiteralExpr<T> negate<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => ScalarOps.negate(eval(a).Value);
    
        [MethodImpl(Inline)]
        static LiteralExpr<T> add<T>(IBinaryArithmeticOp<T> expr)
            where T : unmanaged
                => ScalarOps.add(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static LiteralExpr<T> sub<T>(IBinaryArithmeticOp<T> expr)
            where T : unmanaged
                => ScalarOps.sub(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        static LiteralExpr<T> unhandled<T>(IExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");
    }
}