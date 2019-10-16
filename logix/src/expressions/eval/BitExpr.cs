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
        public static BitLitExpr<T> eval<T>(IBitExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IBitLitExpr<T> x:
                    return eval(x);
                case IBitVarExpr<T> x:
                    return eval(x);
                case IBitOpExpr<T> x:
                    return eval(x);
            }

            return default;
        }

        [MethodImpl(Inline)]
        public static BitLitExpr<T> eval<T>(IBitLitExpr<T> expr)
            where T : unmanaged
            => expr.Value;

        [MethodImpl(Inline)]
        public static BitLitExpr<T> eval<T>(IBitVarExpr<T> expr)
            where T : unmanaged
        {
            if(expr.Value is BitLitExpr<T> l)
                return l.Value;
            else
                return eval(expr.Value);
        }

        public static BitLitExpr<T> eval<T>(IBitOpExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitExpr<T> x:
                    return eval(x);
                case IBinaryBitExpr<T> x:
                    return eval(x);
                case IBitShiftExpr<T> x:
                    return eval(x);
                case ITernaryBitExpr<T> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(IUnaryBitExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Not:
                    return not(expr.Subject);
                case BitOpKind.Negate:
                    return negate(expr.Subject);
                case BitOpKind.Inc:
                    return inc(expr.Subject);
                case BitOpKind.Dec:
                    return dec(expr.Subject);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(IBinaryBitExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.And:
                    return and(expr.Left, expr.Right);
                case BitOpKind.Or:
                    return or(expr.Left, expr.Right);
                case BitOpKind.XOr:
                    return xor(expr.Left, expr.Right);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(IBitShiftExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case BitOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case BitOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case BitOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(ITernaryBitExpr<T> expr)
            where T : unmanaged
        {
            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBitExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IBitLitExpr<Vec128<T>> x:
                    return eval(x);
                case IBitVarExpr<Vec128<T>> x:
                    return eval(x);
                case IBitOpExpr<Vec128<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBitLitExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            return expr.Value;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBitVarExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is BitLitExpr<Vec128<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBitOpExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitExpr<Vec128<T>> x:
                    return eval(x);
                case IBinaryBitExpr<Vec128<T>> x:
                    return eval(x);
                case IBitShiftExpr<Vec128<T>> x:
                    return eval(x);
                case ITernaryBitExpr<Vec128<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IUnaryBitExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Not:
                    return not(expr.Subject);
                case BitOpKind.Negate:
                    return negate(expr.Subject);
                case BitOpKind.Inc:
                    return inc(expr.Subject);
                case BitOpKind.Dec:
                    return dec(expr.Subject);
            }

            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBinaryBitExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.And:
                    return and(expr.Left, expr.Right);
                case BitOpKind.Or:
                    return or(expr.Left, expr.Right);
                case BitOpKind.XOr:
                    return xor(expr.Left, expr.Right);
            }

            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBitShiftExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case BitOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case BitOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case BitOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IBitLitExpr<Vec256<T>> x:
                    return eval(x);
                case IBitVarExpr<Vec256<T>> x:
                    return eval(x);
                case IBitOpExpr<Vec256<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitLitExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            return expr.Value;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitVarExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            if(expr.Value is BitLitExpr<Vec256<T>> x)
                return x.Value;
            else
                return eval(expr.Value);
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitOpExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryBitExpr<Vec256<T>> x:
                    return eval(x);
                case IBinaryBitExpr<Vec256<T>> x:
                    return eval(x);
                case IBitShiftExpr<Vec256<T>> x:
                    return eval(x);
                case ITernaryBitExpr<Vec256<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IUnaryBitExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Not:
                    return not(expr.Subject);
                case BitOpKind.Negate:
                    return negate(expr.Subject);
                case BitOpKind.Inc:
                    return inc(expr.Subject);
                case BitOpKind.Dec:
                    return dec(expr.Subject);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBinaryBitExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.And:
                    return and(expr.Left, expr.Right);
                case BitOpKind.Or:
                    return or(expr.Left, expr.Right);
                case BitOpKind.XOr:
                    return xor(expr.Left, expr.Right);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitShiftExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Sll:
                    return sll(expr.Subject, expr.Offset);
                case BitOpKind.Srl:
                    return srl(expr.Subject, expr.Offset);
                case BitOpKind.Rotl:
                    return rotl(expr.Subject, expr.Offset);
                case BitOpKind.Rotr:
                    return rotr(expr.Subject, expr.Offset);
            }

            return default;
        }

        [MethodImpl(Inline)]
        static BitLitExpr<T> not<T>(IBitExpr<T> a)
            where T : unmanaged
                => gmath.not(eval(a).Value);


        [MethodImpl(Inline)]
        static BitLitExpr<T> negate<T>(IBitExpr<T> a)
            where T : unmanaged
                => gmath.negate(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> and<T>(IBitExpr<T> a, IBitExpr<T> b)
            where T : unmanaged
                => gmath.and(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> or<T>(IBitExpr<T> a, IBitExpr<T> b)
            where T : unmanaged
                => gmath.or(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> xor<T>(IBitExpr<T> a, IBitExpr<T> b)
            where T : unmanaged
                => gmath.xor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> sll<T>(IBitExpr<T> a, IBitExpr<int> b)
            where T : unmanaged
                => gmath.sll(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> srl<T>(IBitExpr<T> a, IBitExpr<int> b)
            where T : unmanaged
                => gmath.srl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> rotl<T>(IBitExpr<T> a, IBitExpr<int> b)
            where T : unmanaged
                => gbits.rotl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> rotr<T>(IBitExpr<T> a, IBitExpr<int> b)
            where T : unmanaged
                => gbits.rotr(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> inc<T>(IBitExpr<T> a)
            where T : unmanaged
                => gmath.inc(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> dec<T>(IBitExpr<T> a)
            where T : unmanaged
                => gmath.dec(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> not<T>(IBitExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> negate<T>(IBitExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vnegate(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> and<T>(IBitExpr<Vec128<T>> a, IBitExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> or<T>(IBitExpr<Vec128<T>> a, IBitExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> xor<T>(IBitExpr<Vec128<T>> a, IBitExpr<Vec128<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> sll<T>(IBitExpr<Vec128<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> srl<T>(IBitExpr<Vec128<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> rotl<T>(IBitExpr<Vec128<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> rotr<T>(IBitExpr<Vec128<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)eval(b).Value);


        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> inc<T>(IBitExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vinc(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> dec<T>(IBitExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vdec(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> not<T>(IBitExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vnot(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> negate<T>(IBitExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vnegate(eval(a).Value);

 
        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> and<T>(IBitExpr<Vec256<T>> a, IBitExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vand(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> or<T>(IBitExpr<Vec256<T>> a, IBitExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vor(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> xor<T>(IBitExpr<Vec256<T>> a, IBitExpr<Vec256<T>> b)
            where T : unmanaged
                => ginx.vxor(eval(a).Value, eval(b).Value);

         [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> sll<T>(IBitExpr<Vec256<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> srl<T>(IBitExpr<Vec256<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> rotl<T>(IBitExpr<Vec256<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> rotr<T>(IBitExpr<Vec256<T>> a, IBitExpr<int> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)eval(b).Value);
 
        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> inc<T>(IBitExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vinc(eval(a).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> dec<T>(IBitExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vdec(eval(a).Value);
   }
}