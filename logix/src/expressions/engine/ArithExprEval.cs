//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using UAK =  UnaryArithmeticOpKind;

    public static class ArithExprEval
    {
        public static LiteralExpr<T> eval<T>(IArithmeticExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteralExpr<T> x:
                    return eval(x);
                case IVarExpr<T> x:
                    return eval(x);
                case IArithmeticOp<T> x:
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
        static LiteralExpr<T> eval<T>(IVarExpr<T> expr)
            where T : unmanaged
        {
            if(expr.Value is LiteralExpr<T> l)
                return l.Value;
            else
                return eval(expr.Value as IArithmeticExpr<T>);
        }

        [MethodImpl(Inline)]
        static LiteralExpr<T> eval<T>(IArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr)               
            {
                case IUnaryArithmeticOp<T> x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }

        }

        [MethodImpl(Inline)]
        static LiteralExpr<T> eval<T>(IUnaryArithmeticOp<T> expr)
            where T : unmanaged
        {
            switch(expr.OpKind)               
            {
                case UAK.Inc: return inc(expr);
                case UAK.Dec: return dec(expr);
                case UAK.Negate: return negate(expr);
                default: return unhandled(expr);
            }
        }

        static LiteralExpr<T> unhandled<T>(IExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");


       [MethodImpl(Inline)]
        static LiteralExpr<T> inc<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => gmath.inc(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> dec<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => gmath.dec(eval(a).Value);

        [MethodImpl(Inline)]
        static LiteralExpr<T> negate<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => gmath.negate(eval(a).Value);

    }

}


