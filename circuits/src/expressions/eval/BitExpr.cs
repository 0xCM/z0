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
                case IBitLiteralExpr<T> x:
                    return eval(x);
                case IBitVarExpr<T> x:
                    return eval(x);
                case IBitOpExpr<T> x:
                    return eval(x);
            }

            return default;
        }

        [MethodImpl(Inline)]
        public static BitLitExpr<T> eval<T>(IBitLiteralExpr<T> expr)
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
                case IUnaryBitwiseExpr<T> x:
                    return eval(x);
                case IBinaryBitwiseExpr<T> x:
                    return eval(x);
                case IMixedBitwiseExpr<T> x:
                    return eval(x);
                case ITernaryBitwiseExpr<T> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(IUnaryBitwiseExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Not:
                    return not(expr.Operand);
                case BitOpKind.Negate:
                    return negate(expr.Operand);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(IBinaryBitwiseExpr<T> expr)
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

        public static BitLitExpr<T> eval<T>(IMixedBitwiseExpr<T> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Sll:
                    return sll(expr.Left, expr.Right);
                case BitOpKind.Srl:
                    return srl(expr.Left, expr.Right);
                case BitOpKind.Rotl:
                    return rotl(expr.Left, expr.Right);
                case BitOpKind.Rotr:
                    return rotr(expr.Left, expr.Right);
            }

            return default;
        }

        public static BitLitExpr<T> eval<T>(ITernaryBitwiseExpr<T> expr)
            where T : unmanaged
        {
            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBitExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IBitLiteralExpr<Vec128<T>> x:
                    return eval(x);
                case IBitVarExpr<Vec128<T>> x:
                    return eval(x);
                case IBitOpExpr<Vec128<T>> x:
                    return eval(x);
            }

            return default;
        }


        public static BitLitExpr<Vec128<T>> eval<T>(IBitLiteralExpr<Vec128<T>> expr)
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
                case IUnaryBitwiseExpr<Vec128<T>> x:
                    return eval(x);
                case IBinaryBitwiseExpr<Vec128<T>> x:
                    return eval(x);
                case IMixedBitwiseExpr<Vec128<T>> x:
                    return eval(x);
                case ITernaryBitwiseExpr<Vec128<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IUnaryBitwiseExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Not:
                    return not(expr.Operand);
                case BitOpKind.Negate:
                    return negate(expr.Operand);
            }

            return default;
        }

        public static BitLitExpr<Vec128<T>> eval<T>(IBinaryBitwiseExpr<Vec128<T>> expr)
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

        public static BitLitExpr<Vec128<T>> eval<T>(IMixedBitwiseExpr<Vec128<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Sll:
                    return sll(expr.Left, expr.Right);
                case BitOpKind.Srl:
                    return srl(expr.Left, expr.Right);
                case BitOpKind.Rotl:
                    return rotl(expr.Left, expr.Right);
                case BitOpKind.Rotr:
                    return rotr(expr.Left, expr.Right);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case IBitLiteralExpr<Vec256<T>> x:
                    return eval(x);
                case IBitVarExpr<Vec256<T>> x:
                    return eval(x);
                case IBitOpExpr<Vec256<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBitLiteralExpr<Vec256<T>> expr)
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
                case IUnaryBitwiseExpr<Vec256<T>> x:
                    return eval(x);
                case IBinaryBitwiseExpr<Vec256<T>> x:
                    return eval(x);
                case IMixedBitwiseExpr<Vec256<T>> x:
                    return eval(x);
                case ITernaryBitwiseExpr<Vec256<T>> x:
                    return eval(x);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IUnaryBitwiseExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Not:
                    return not(expr.Operand);
                case BitOpKind.Negate:
                    return negate(expr.Operand);
            }

            return default;
        }

        public static BitLitExpr<Vec256<T>> eval<T>(IBinaryBitwiseExpr<Vec256<T>> expr)
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

        public static BitLitExpr<Vec256<T>> eval<T>(IMixedBitwiseExpr<Vec256<T>> expr)
            where T : unmanaged
        {
            switch(expr.Operator)
            {
                case BitOpKind.Sll:
                    return sll(expr.Left, expr.Right);
                case BitOpKind.Srl:
                    return srl(expr.Left, expr.Right);
                case BitOpKind.Rotl:
                    return rotl(expr.Left, expr.Right);
                case BitOpKind.Rotr:
                    return rotr(expr.Left, expr.Right);
            }

            return default;
        }

        [MethodImpl(Inline)]
        static BitLitExpr<T> not<T>(IBitExpr<T> a)
            where T : unmanaged
                => gmath.flip(eval(a).Value);

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
        static BitLitExpr<T> sll<T>(IBitExpr<T> a, IBitExpr<uint> b)
            where T : unmanaged
                => gmath.sll(eval(a).Value, (int)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> srl<T>(IBitExpr<T> a, IBitExpr<uint> b)
            where T : unmanaged
                => gmath.srl(eval(a).Value, (int)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> rotl<T>(IBitExpr<T> a, IBitExpr<uint> b)
            where T : unmanaged
                => gbits.rotl(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<T> rotr<T>(IBitExpr<T> a, IBitExpr<uint> b)
            where T : unmanaged
                => gbits.rotr(eval(a).Value, eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> not<T>(IBitExpr<Vec128<T>> a)
            where T : unmanaged
                => ginx.vflip(eval(a).Value);

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
        static BitLitExpr<Vec128<T>> sll<T>(IBitExpr<Vec128<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> srl<T>(IBitExpr<Vec128<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> rotl<T>(IBitExpr<Vec128<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec128<T>> rotr<T>(IBitExpr<Vec128<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)eval(b).Value);


        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> not<T>(IBitExpr<Vec256<T>> a)
            where T : unmanaged
                => ginx.vflip(eval(a).Value);

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
        static BitLitExpr<Vec256<T>> sll<T>(IBitExpr<Vec256<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vsll(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> srl<T>(IBitExpr<Vec256<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vsrl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> rotl<T>(IBitExpr<Vec256<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vrotl(eval(a).Value, (byte)eval(b).Value);

        [MethodImpl(Inline)]
        static BitLitExpr<Vec256<T>> rotr<T>(IBitExpr<Vec256<T>> a, IBitExpr<uint> b)
            where T : unmanaged
                => ginx.vrotr(eval(a).Value, (byte)eval(b).Value);
   }

}