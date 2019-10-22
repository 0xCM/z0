//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    static class ScalarExprEval
    {
        public static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteralExpr<T> x:
                    return eval(x);
                case IVariable<T> x:
                    return eval(x);
                case IOpExpr<T> x:
                    return eval(x);
                case IEqualityExpr<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        [MethodImpl(Inline)]
        static LiteralExpr<T> eval<T>(ILiteralExpr<T> expr)
            where T : unmanaged
                => expr.Value;

        [MethodImpl(Inline)]
        static LiteralExpr<T> eval<T>(IVariable<T> expr)
            where T : unmanaged
        {
            if(expr.Value is LiteralExpr<T> l)
                return l.Value;
            else
                return eval(expr.Value);
        }

        [MethodImpl(Inline)]
        static LiteralExpr<T> eval<T>(IEqualityExpr<T> expr)
            where T : unmanaged
                => xnor(eval(expr.Lhs), eval(expr.Rhs));

        static LiteralExpr<T> eval<T>(IOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryOp<T> x:
                    return eval(x);
                case IBinaryOp<T> x:
                    return eval(x);
                case IShiftOp<T> x:
                    return eval(x);
                case ITernaryOp<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        static LiteralExpr<T> eval<T>(IUnaryOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)
            {
                case UnaryLogicOpKind.Not:
                    return not(expr.Operand);
                case UnaryLogicOpKind.Negate:
                    return negate(expr.Operand);
                case UnaryLogicOpKind.Inc:
                    return inc(expr.Operand);
                case UnaryLogicOpKind.Dec:
                    return dec(expr.Operand);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<T> eval<T>(IBinaryOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)
            {
                case BinaryLogicOpKind.True:
                    return @true(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.And:
                    return and(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.Or:
                    return or(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.XOr:
                    return xor(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.Nand:
                    return nand(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.Nor:
                    return nor(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.Xnor:
                    return xnor(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.AndNot:
                    return andnot(expr.LeftArg, expr.RightArg);
                case BinaryLogicOpKind.False:
                    return @false(expr.LeftArg, expr.RightArg);
                default:
                    return unhandled(expr);
            }
        }

        static LiteralExpr<T> eval<T>(IShiftOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)
            {
                case ShiftOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case ShiftOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
                default:
                    return unhandled(expr);
            }

        }

        [MethodImpl(Inline)]
        static LiteralExpr<T> eval<T>(ITernaryOp<T> expr)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        static LiteralExpr<T> not<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.not(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> @true<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.maxval<T>();

        [MethodImpl(Inline)]
        static LiteralExpr<T> @false<T>(IExpr<T> a)
            where T : unmanaged
                => default(T);

        [MethodImpl(Inline)]
        static LiteralExpr<T> @true<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.maxval<T>();

        [MethodImpl(Inline)]
        static LiteralExpr<T> @false<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => default(T);

        [MethodImpl(Inline)]
        static LiteralExpr<T> negate<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.negate(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> and<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.and(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> nand<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.nand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> or<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.or(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> nor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.nor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> xor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.xor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> xnor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.xnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> andnot<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.andnot(eval(a).Value, eval(b).Value);

 
        [MethodImpl(Inline)]
        static LiteralExpr<T> sll<T>(IExpr<T> a, IExpr<int> offset)
            where T : unmanaged
                => gmath.sll(eval(a).Value, eval(offset).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> srl<T>(IExpr<T> a, IExpr<int> offset)
            where T : unmanaged
                => gmath.srl(eval(a).Value, eval(offset).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> rotl<T>(IExpr<T> a, IExpr<int> offset)
            where T : unmanaged
                => gbits.rotl(eval(a).Value, eval(offset).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> rotr<T>(IExpr<T> a, IExpr<int> offset)
            where T : unmanaged
                => gbits.rotr(eval(a).Value, eval(offset).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> inc<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.inc(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> dec<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.dec(eval(a).Value);

        static LiteralExpr<T> unhandled<T>(IExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");

    }

}