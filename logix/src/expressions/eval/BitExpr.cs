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

    public static class BitExpr
    {
        public static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<T> x:
                    return eval(x);
                case IVarExpr<T> x:
                    return eval(x);
                case IOpExpr<T> x:
                    return eval(x);
            }

            return default;
        }

        [MethodImpl(Inline)]
        public static LiteralExpr<T> eval<T>(ILiteral<T> expr)
            where T : unmanaged
            => expr.Value;

        [MethodImpl(Inline)]
        public static LiteralExpr<T> eval<T>(IVarExpr<T> expr)
            where T : unmanaged
        {
            if(expr.Value is LiteralExpr<T> l)
                return l.Value;
            else
                return eval(expr.Value);
        }

        public static LiteralExpr<T> eval<T>(IOpExpr<T> expr)
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
            }

            return default;
        }

        public static LiteralExpr<T> eval<T>(IUnaryLogicOp<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case UnaryLogicKind.Not:
                    return not(expr.Operand);
                case UnaryLogicKind.Negate:
                    return negate(expr.Operand);
                case UnaryLogicKind.Inc:
                    return inc(expr.Operand);
                case UnaryLogicKind.Dec:
                    return dec(expr.Operand);
            }

            return default;
        }

        public static LiteralExpr<T> eval<T>(IBinaryLogicOp<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BinaryLogicKind.And:
                    return and(expr.Left, expr.Right);
                case BinaryLogicKind.Or:
                    return or(expr.Left, expr.Right);
                case BinaryLogicKind.XOr:
                    return xor(expr.Left, expr.Right);
            }

            return default;
        }

        public static LiteralExpr<T> eval<T>(IShiftOp<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case ShiftOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case ShiftOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
            }

            return default;
        }

        public static LiteralExpr<T> eval<T>(ITernaryLogicOp<T> expr)
            where T : unmanaged
        {
            return default;
        }

        public static LiteralExpr<Vec128<T>> eval<T>(IExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<Vec128<T>> x:
                    return eval(x);
                case IVarExpr<Vec128<T>> x:
                    return eval(x);
                case IOpExpr<Vec128<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static LiteralExpr<Vec128<T>> eval<T>(ILiteral<Vec128<T>> expr)
            where T : unmanaged
        {
            return expr.Value;
        }

        public static LiteralExpr<Vec128<T>> eval<T>(IVarExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is LiteralExpr<Vec128<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        public static LiteralExpr<Vec128<T>> eval<T>(IOpExpr<Vec128<T>> expr)
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
            }

            return default;
        }

        public static LiteralExpr<Vec128<T>> eval<T>(IUnaryLogicOp<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case UnaryLogicKind.Not:
                    return not(expr.Operand);
                case UnaryLogicKind.Negate:
                    return negate(expr.Operand);
                case UnaryLogicKind.Inc:
                    return inc(expr.Operand);
                case UnaryLogicKind.Dec:
                    return dec(expr.Operand);
            }

            return default;
        }

        public static LiteralExpr<Vec128<T>> eval<T>(IBinaryLogicOp<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BinaryLogicKind.And:
                    return and(expr.Left, expr.Right);
                case BinaryLogicKind.Or:
                    return or(expr.Left, expr.Right);
                case BinaryLogicKind.XOr:
                    return xor(expr.Left, expr.Right);
            }

            return default;
        }

        public static LiteralExpr<Vec128<T>> eval<T>(IShiftOp<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case ShiftOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case ShiftOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
            }

            return default;
        }

        public static LiteralExpr<Vec256<T>> eval<T>(IExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<Vec256<T>> x:
                    return eval(x);
                case IVarExpr<Vec256<T>> x:
                    return eval(x);
                case IOpExpr<Vec256<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static LiteralExpr<Vec256<T>> eval<T>(ILiteral<Vec256<T>> expr)
            where T : unmanaged
        {
            return expr.Value;
        }

        public static LiteralExpr<Vec256<T>> eval<T>(IVarExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is LiteralExpr<Vec256<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        public static LiteralExpr<Vec256<T>> eval<T>(IOpExpr<Vec256<T>> expr)
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
            }

            return default;
        }

        public static LiteralExpr<Vec256<T>> eval<T>(IUnaryLogicOp<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case UnaryLogicKind.Not:
                    return not(expr.Operand);
                case UnaryLogicKind.Negate:
                    return negate(expr.Operand);
                case UnaryLogicKind.Inc:
                    return inc(expr.Operand);
                case UnaryLogicKind.Dec:
                    return dec(expr.Operand);
            }

            return default;
        }

        public static LiteralExpr<Vec256<T>> eval<T>(IBinaryLogicOp<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BinaryLogicKind.And:
                    return and(expr.Left, expr.Right);
                case BinaryLogicKind.Or:
                    return or(expr.Left, expr.Right);
                case BinaryLogicKind.XOr:
                    return xor(expr.Left, expr.Right);
            }

            return default;
        }

        public static LiteralExpr<Vec256<T>> eval<T>(IShiftOp<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case ShiftOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case ShiftOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case ShiftOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
            }

            return default;
        }

        [MethodImpl(Inline)]
        static LiteralExpr<T> not<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.not(eval(a).Value);


        [MethodImpl(Inline)]
        static LiteralExpr<T> negate<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.negate(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> and<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.and(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> or<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.or(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> xor<T>(IExpr<T> a, IExpr<T> b)
            where T : unmanaged
                => gmath.xor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> sll<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gmath.sll(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> srl<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gmath.srl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> rotl<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gbits.rotl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> rotr<T>(IExpr<T> a, IExpr<int> b)
            where T : unmanaged
                => gbits.rotr(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> inc<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.inc(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> dec<T>(IExpr<T> a)
            where T : unmanaged
                => gmath.dec(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> not<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> negate<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vnegate(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> and<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> or<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> xor<T>(IExpr<Vec128<T>> a, IExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> sll<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> srl<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> rotl<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> rotr<T>(IExpr<Vec128<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)eval(b).Value);


        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> inc<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vinc(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec128<T>> dec<T>(IExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vdec(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> not<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> negate<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vnegate(eval(a).Value);

 
        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> and<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> or<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> xor<T>(IExpr<Vec256<T>> a, IExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

         [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> sll<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> srl<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> rotl<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> rotr<T>(IExpr<Vec256<T>> a, IExpr<int> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)eval(b).Value);
 
        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> inc<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vinc(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<Vec256<T>> dec<T>(IExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vdec(eval(a).Value);
   }
}