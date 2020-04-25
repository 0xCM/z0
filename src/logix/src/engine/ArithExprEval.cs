//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static LogicSig;

    using UAR = UnaryArithmeticKind;

    [ApiHost("expr.arith.eval")]
    public class ArithExprEval : IApiHost<ArithExprEval>
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
                case IArithmeticOpExpr<T> x:
                    return eval(x);
                default: throw new NotSupportedException(expr.GetType().Name);
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

        static LiteralExpr<T> eval<T>(IArithmeticOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryArithmeticOpExpr<T> x:
                    return eval(x);
                case IBinaryArithmeticOpExpr<T> x:
                    return eval(x);
                default: throw new NotSupportedException(expr.GetType().Name);
            }
        }

        static LiteralExpr<T> eval<T>(IBinaryArithmeticOpExpr<T> expr)
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
                        default: throw new NotSupportedException(sig<T>(expr.OpKind));
                    }
            }
        }

        static LiteralExpr<T> eval<T>(IUnaryArithmeticOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)               
            {
                case UAR.Inc: return inc(expr);
                case UAR.Dec: return dec(expr);
                case UAR.Negate: return negate(expr);
                default: throw new NotSupportedException(sig<T>(expr.OpKind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        static LiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => PredicateApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op, NumericClosures(NumericKind.Integers)]
        static LiteralExpr<T> inc<T>(IUnaryArithmeticOpExpr<T> a)
            where T : unmanaged
                => NumericBits.inc(eval(a).Value);

        [Op, NumericClosures(NumericKind.Integers)]
        static LiteralExpr<T> dec<T>(IUnaryArithmeticOpExpr<T> a)
            where T : unmanaged
                => NumericBits.dec(eval(a).Value);

        [Op, NumericClosures(NumericKind.Integers)]
        static LiteralExpr<T> negate<T>(IUnaryArithmeticOpExpr<T> a)
            where T : unmanaged
                => NumericBits.negate(eval(a).Value);
    
        [Op, NumericClosures(NumericKind.Integers)]
        static LiteralExpr<T> add<T>(IBinaryArithmeticOpExpr<T> expr)
            where T : unmanaged
                => NumericBits.add(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op, NumericClosures(NumericKind.Integers)]
        static LiteralExpr<T> sub<T>(IBinaryArithmeticOpExpr<T> expr)
            where T : unmanaged
                => NumericBits.sub(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);
    }
}