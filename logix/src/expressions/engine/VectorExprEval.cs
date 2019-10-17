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


    static class VectorExprEval
    {
         public static Literal<Vec128<T>> eval<T>(IExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<Vec128<T>> x:
                    return eval(x);
                case IVariable<Vec128<T>> x:
                    return eval(x);
                case IOpExpr<Vec128<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        public static Literal<Vec256<T>> eval<T>(IExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<Vec256<T>> x:
                    return eval(x);
                case IVariable<Vec256<T>> x:
                    return eval(x);
                case IOpExpr<Vec256<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> eval<T>(ILiteral<Vec128<T>> expr)
            where T : unmanaged        
                => expr.Value;        

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> eval<T>(IVariable<Vec128<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is Literal<Vec128<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        static Literal<Vec128<T>> eval<T>(IOpExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryLogicOp<Vec128<T>> x:
                    return eval(x);
                case IBinaryLogicOp<Vec128<T>> x:
                    return eval(x);
                case IShiftOp<Vec128<T>> x:
                    return eval(x);
                case ITernaryLogicOp<Vec128<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        static Literal<Vec128<T>> eval<T>(IUnaryLogicOp<Vec128<T>> expr)
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

        static Literal<Vec128<T>> eval<T>(IBinaryLogicOp<Vec128<T>> expr)
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

        static Literal<Vec128<T>> eval<T>(IShiftOp<Vec128<T>> expr)
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
        static Literal<Vec256<T>> eval<T>(ILiteral<Vec256<T>> expr)
            where T : unmanaged        
                => expr.Value;
        

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> eval<T>(IVariable<Vec256<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is Literal<Vec256<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        static Literal<Vec256<T>> eval<T>(IOpExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryLogicOp<Vec256<T>> x:
                    return eval(x);
                case IBinaryLogicOp<Vec256<T>> x:
                    return eval(x);
                case IShiftOp<Vec256<T>> x:
                    return eval(x);
                case ITernaryLogicOp<Vec256<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        static Literal<Vec256<T>> eval<T>(IUnaryLogicOp<Vec256<T>> expr)
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

        static Literal<Vec256<T>> eval<T>(IBinaryLogicOp<Vec256<T>> expr)
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

        static Literal<Vec256<T>> eval<T>(IShiftOp<Vec256<T>> expr)
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
        static Literal<Vec128<T>> not<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> negate<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vnegate(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> and<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> nand<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vnand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> or<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> nor<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> xor<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> xnor<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vxnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> sll<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> srl<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> rotl<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> rotr<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> inc<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vinc(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec128<T>> dec<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vdec(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> not<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> negate<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vnegate(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> and<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> or<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> xor<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> nand<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vnand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> nor<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> xnor<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vxnor(eval(a).Value, eval(b).Value);


         [MethodImpl(Inline)]
        static Literal<Vec256<T>> sll<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> srl<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> rotl<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> rotr<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)ScalarExprEval.eval(b).Value);
 
        [MethodImpl(Inline)]
        static Literal<Vec256<T>> inc<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vinc(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vec256<T>> dec<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vdec(eval(a).Value);

        public static Literal<Vec128<T>> unhandled<T>(IExpr<Vec128<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");

        public static Literal<Vec256<T>> unhandled<T>(IExpr<Vec256<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");
    }
}