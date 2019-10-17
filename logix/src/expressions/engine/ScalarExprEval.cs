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
        public static Literal<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<T> x:
                    return eval(x);
                case IVariable<T> x:
                    return eval(x);
                case IOpExpr<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        [MethodImpl(Inline)]
        static Literal<T> eval<T>(ILiteral<T> expr)
            where T : unmanaged
                => expr.Value;

        [MethodImpl(Inline)]
        static Literal<T> eval<T>(IVariable<T> expr)
            where T : unmanaged
        {
            if(expr.Value is Literal<T> l)
                return l.Value;
            else
                return eval(expr.Value);
        }

        static Literal<T> eval<T>(IOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryLogicOp<T> x:
                    return eval(x);
                case IBinaryLogicOp<T> x:
                    return eval(x);
                case IShiftOp<T> x:
                    return eval(x);
                case ITernaryLogicOp<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        static Literal<T> eval<T>(IUnaryLogicOp<T> expr)
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

        static Literal<T> eval<T>(IBinaryLogicOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)
            {
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
                default:
                    return unhandled(expr);
            }
        }

        static Literal<T> eval<T>(IShiftOp<T> expr)
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
        static Literal<T> eval<T>(ITernaryLogicOp<T> expr)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        static Literal<T> not<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.not(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<T> negate<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.negate(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<T> and<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.and(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> nand<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.nand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> or<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.or(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> nor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.nor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> xor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.xor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> xnor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.xnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> sll<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gmath.sll(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> srl<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gmath.srl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> rotl<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gbits.rotl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> rotr<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gbits.rotr(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<T> inc<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.inc(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<T> dec<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.dec(eval(a).Value);

        static Literal<T> unhandled<T>(IExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");

    }

}