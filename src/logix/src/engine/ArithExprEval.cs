//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    using static Part;
    using static LogicSig;

    using UAR = UnaryArithmeticApiClass;

    public class ArithExprEval
    {
        [Op, NumericClosures(UnsignedInts)]
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
                default: throw Unsupported.define<T>();
            }
        }

        [Op, Closures(UnsignedInts)]
        static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IArithmeticExpr<T> x: return eval(x);
                default: return LogicEngine.eval(expr);
            }
        }

       [Op, Closures(UnsignedInts)]
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

        [Op, Closures(UnsignedInts)]
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

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> eval<T>(IBinaryArithmeticOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IComparisonExpr<T> x:
                    return eval(x);
                default:
                    switch(expr.ApiClass)
                    {
                        case BinaryArithmeticApiClass.Add: return add(expr);
                        case BinaryArithmeticApiClass.Sub: return sub(expr);
                        default: throw new NotSupportedException(sig<T>(expr.ApiClass));
                    }
            }
        }

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> eval<T>(IUnaryArithmeticOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.ApiClass)
            {
                case UAR.Inc: return inc(expr);
                case UAR.Dec: return dec(expr);
                case UAR.Negate: return negate(expr);
                default: throw new NotSupportedException(sig<T>(expr.ApiClass));
            }
        }

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => PredicateApi.eval(expr.ComparisonKind, eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> inc<T>(IUnaryArithmeticOpExpr<T> a)
            where T : unmanaged
                => NumericLogix.inc(eval(a).Value);

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> dec<T>(IUnaryArithmeticOpExpr<T> a)
            where T : unmanaged
                => NumericLogix.dec(eval(a).Value);

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> negate<T>(IUnaryArithmeticOpExpr<T> a)
            where T : unmanaged
                => NumericLogix.negate(eval(a).Value);

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> add<T>(IBinaryArithmeticOpExpr<T> expr)
            where T : unmanaged
                => NumericLogix.add(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);

        [Op, NumericClosures(UnsignedInts)]
        static LiteralExpr<T> sub<T>(IBinaryArithmeticOpExpr<T> expr)
            where T : unmanaged
                => NumericLogix.sub(eval(expr.LeftArg).Value, eval(expr.RightArg).Value);
    }
}