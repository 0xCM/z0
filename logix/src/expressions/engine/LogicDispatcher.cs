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

    /// <summary>
    /// Routes expressions to evaluators
    /// </summary>
    public readonly struct LogicDispatcher : ILogicDispatcher
    {
        public static ILogicDispatcher Instance => new LogicDispatcher();

        bit unhandled(ILogicExpr expr)
            => throw new Exception($"{expr} unhandled");

        bit Dispatch(IEqualityExpr expr)
            => Eval(expr.Lhs) == Eval(expr.Rhs);

        bit Dispatch(ILogicVarExpr expr)
            => Eval(expr.Value);

        bit Dispatch(IVariedLogicExpr expr)
            => Eval(expr.BaseExpr);

        bit Dispatch(ILogicLiteral expr)
            => expr.Value;

        bit Dispatch(IUnaryLogicOp expr)
            => LogicOpApi.eval(expr.OpKind, Eval(expr.Arg));

        bit Dispatch(IBinaryLogicOp expr)
            => LogicOpApi.eval(expr.OpKind, Eval(expr.LeftArg), Eval(expr.RightArg));

        bit Dispatch(ITernaryLogicOp expr)
            => LogicOpApi.eval(expr.OpKind,
                    Eval(expr.FirstArg), 
                    Eval(expr.SecondArg), 
                    Eval(expr.ThirdArg
                    ));  

        public bit Eval(ILogicExpr expr)
        {
            switch(expr)
            {
                case ILogicLiteral x:
                    return Dispatch(x);
                case IEqualityExpr x:
                    return Dispatch(x);
                case ILogicVarExpr x:
                    return Dispatch(x);
                case IVariedLogicExpr x:
                    return Dispatch(x);
                case IBinaryLogicOp x:
                    return Dispatch(x);
                case IUnaryLogicOp x:
                    return Dispatch(x);
                case ITernaryLogicOp x:
                    return Dispatch(x);
                default:
                    return unhandled(expr);
            }
        }        

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with 
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [MethodImpl(Inline)]
        public bit Satisfied(EqualityExpr expr, bit a, bit b)
        {
            expr.SetVars(a,b);
            return Dispatch(expr);
        }
    }
}