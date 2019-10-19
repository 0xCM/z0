//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    static class VectorExprEval
    {
         public static Literal<Vector128<T>> eval<T>(IExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<Vector128<T>> x:
                    return eval(x);
                case IVariable<Vector128<T>> x:
                    return eval(x);
                case IOpExpr<Vector128<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        public static Literal<Vector256<T>> eval<T>(IExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<Vector256<T>> x:
                    return eval(x);
                case IVariable<Vector256<T>> x:
                    return eval(x);
                case IOpExpr<Vector256<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }


        [MethodImpl(Inline)]
        static Literal<Vector128<T>> eval<T>(ILiteral<Vector128<T>> expr)
            where T : unmanaged        
                => expr.Value;        


        [MethodImpl(Inline)]
        static Literal<Vector128<T>> eval<T>(IVariable<Vector128<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is Literal<Vector128<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        static Literal<Vector128<T>> eval<T>(IOpExpr<Vector128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryLogicOp<Vector128<T>> x:
                    return eval(x);
                case IBinaryLogicOp<Vector128<T>> x:
                    return eval(x);
                case IShiftOp<Vector128<T>> x:
                    return eval(x);
                case ITernaryLogicOp<Vector128<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        static Literal<Vector128<T>> eval<T>(IUnaryLogicOp<Vector128<T>> expr)
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

        static Literal<Vector128<T>> eval<T>(IBinaryLogicOp<Vector128<T>> expr)
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

        static Literal<Vector128<T>> eval<T>(IShiftOp<Vector128<T>> expr)
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
        static Literal<Vector256<T>> eval<T>(ILiteral<Vector256<T>> expr)
            where T : unmanaged        
                => expr.Value;
        

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> eval<T>(IVariable<Vector256<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is Literal<Vector256<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        static Literal<Vector256<T>> eval<T>(IOpExpr<Vector256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryLogicOp<Vector256<T>> x:
                    return eval(x);
                case IBinaryLogicOp<Vector256<T>> x:
                    return eval(x);
                case IShiftOp<Vector256<T>> x:
                    return eval(x);
                case ITernaryLogicOp<Vector256<T>> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        static Literal<Vector256<T>> eval<T>(IUnaryLogicOp<Vector256<T>> expr)
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

        static Literal<Vector256<T>> eval<T>(IBinaryLogicOp<Vector256<T>> expr)
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

        static Literal<Vector256<T>> eval<T>(IShiftOp<Vector256<T>> expr)
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
        static Literal<Vector128<T>> not<T>(IExpr<Vector128<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> negate<T>(IExpr<Vector128<T>> a)
            where T : unmanaged
        {
            Vector128<T> b =  ginx.vnegate<T>(eval(a).Value);
            return b;
        }
                
        [MethodImpl(Inline)]
        static Literal<Vector128<T>> and<T>(IExpr<Vector128<T>> a, IExpr<Vector128<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> nand<T>(IExpr<Vector128<T>> a, IExpr<Vector128<T>> b)
            where T : unmanaged
                => ginx.vnand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> or<T>(IExpr<Vector128<T>> a, IExpr<Vector128<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> nor<T>(IExpr<Vector128<T>> a, IExpr<Vector128<T>> b)
            where T : unmanaged
                => ginx.vnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> xor<T>(IExpr<Vector128<T>> a, IExpr<Vector128<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> xnor<T>(IExpr<Vector128<T>> a, IExpr<Vector128<T>> b)
            where T : unmanaged
                => ginx.vxnor(eval(a).Value, eval(b).Value);


        [MethodImpl(Inline)]
        static Literal<Vector128<T>> sll<T>(IExpr<Vector128<T>> x, IExpr<int> offset)
            where T : unmanaged
        {
            Vector128<T> y = ginx.vsll<T>(eval(x).Value, (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> srl<T>(IExpr<Vector128<T>> x, IExpr<int> offset)
            where T : unmanaged
        {
            Vector128<T> y = ginx.vsrl<T>(eval(x).Value, (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> rotl<T>(IExpr<Vector128<T>> a, IExpr<int> offset)
            where T : unmanaged
        {
            Vector128<T> y = ginx.vrotl<T>(eval(a).Value, (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> rotr<T>(IExpr<Vector128<T>> a, IExpr<int> offset)
            where T : unmanaged
        {
            Vector128<T> y = ginx.vrotr<T>(eval(a).Value, (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }


        [MethodImpl(Inline)]
        static Literal<Vector128<T>> inc<T>(IExpr<Vector128<T>> a)
            where T : unmanaged
        {
                Vector128<T> y = ginx.vinc<T>(eval(a).Value);
                return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector128<T>> dec<T>(IExpr<Vector128<T>> a)
            where T : unmanaged
        {
                Vector128<T> y = ginx.vdec<T>(eval(a).Value);
                return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> not<T>(IExpr<Vector256<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> negate<T>(IExpr<Vector256<T>> a)
            where T : unmanaged
        {
                Vector256<T> y = ginx.vnegate<T>(eval(a).Value);
                return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> and<T>(IExpr<Vector256<T>> a, IExpr<Vector256<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> or<T>(IExpr<Vector256<T>> a, IExpr<Vector256<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> xor<T>(IExpr<Vector256<T>> a, IExpr<Vector256<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> nand<T>(IExpr<Vector256<T>> a, IExpr<Vector256<T>> b)
            where T : unmanaged
                => ginx.vnand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> nor<T>(IExpr<Vector256<T>> a, IExpr<Vector256<T>> b)
            where T : unmanaged
                => ginx.vnor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> xnor<T>(IExpr<Vector256<T>> a, IExpr<Vector256<T>> b)
            where T : unmanaged
                => ginx.vxnor(eval(a).Value, eval(b).Value);
                
        [MethodImpl(Inline)]
        static Literal<Vector256<T>> sll<T>(IExpr<Vector256<T>> x, IExpr<int> offset)
            where T : unmanaged
        {
            Vector256<T> y = ginx.vsll<T>(eval(x).Value,  (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> srl<T>(IExpr<Vector256<T>> x, IExpr<int> offset)
            where T : unmanaged
        {
            Vector256<T> y = ginx.vsrl<T>(eval(x).Value,  (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> rotl<T>(IExpr<Vector256<T>> x, IExpr<int> offset)
            where T : unmanaged
        {
            Vector256<T> y = ginx.vrotl<T>(eval(x).Value, (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> rotr<T>(IExpr<Vector256<T>> a, IExpr<int> offset)
            where T : unmanaged
        {
            Vector256<T> y = ginx.vrotr<T>(eval(a).Value, (byte)ScalarExprEval.eval(offset).Value);
            return y;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> inc<T>(IExpr<Vector256<T>> a)
            where T : unmanaged
        {
            Vector256<T> b = ginx.vinc<T>(eval(a).Value);
            return b;
        }

        [MethodImpl(Inline)]
        static Literal<Vector256<T>> dec<T>(IExpr<Vector256<T>> a)
            where T : unmanaged
        {
            Vector256<T> b = ginx.vdec<T>(eval(a).Value);
            return b;
        }

        static Literal<Vector128<T>> unhandled<T>(IExpr<Vector128<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");

        static Literal<Vector256<T>> unhandled<T>(IExpr<Vector256<T>> expr)       
            where T : unmanaged
                => throw new Exception($"{expr} unhandled");
    }
}