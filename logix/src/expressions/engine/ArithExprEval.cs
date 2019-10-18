//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using UAK =  UnaryArithmeticOpKind;

    public static class ArithExprEval
    {
        public static Literal<T> eval<T>(IArithmeticExpr<T> expr)
            where T : unmanaged
        {
            switch(expr)
            {
                case ILiteral<T> x:
                    return eval(x);
                case IVariable<T> x:
                    return eval(x);
                case IArithmeticOp<T> x:
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
                return eval(expr.Value as IArithmeticExpr<T>);
        }

        [MethodImpl(Inline)]
        static Literal<T> eval<T>(IArithmeticOp<T> expr)
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
        static Literal<T> eval<T>(IUnaryArithmeticOp<T> expr)
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

        static Literal<T> unhandled<T>(IExpr<T> a)
            where T : unmanaged
                => throw new Exception($"{a} unhandled");


       [MethodImpl(Inline)]
        static Literal<T> inc<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => gmath.inc(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<T> dec<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => gmath.dec(eval(a).Value);

        [MethodImpl(Inline)]
        static Literal<T> negate<T>(IUnaryArithmeticOp<T> a)
            where T : unmanaged
                => gmath.negate(eval(a).Value);

    }

}


