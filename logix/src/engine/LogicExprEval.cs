//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class LogicExprEval
    {
        internal static bit eval(ILogicExpr expr)
        {
            switch(expr)               
            {
                case ILogicVarExpr x:
                    return eval(x.Value);
                case IVariedLogicExpr x:
                    return eval(x.BaseExpr);
                case ILogicLiteral x:
                    return x.Value;
                case ILogicOp x:
                    return eval(x);
                case IComparisonExpr x:
                    return eval(x.Lhs) == eval(x.Rhs);
                default: 
                    return unhandled(expr);
            }
        }

        /// <summary>
        /// Evaluates a logical operator expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        static bit eval(ILogicOp expr)
        {
            switch(expr)               
            {
                case IUnaryLogicOp x:
                    return LogicOpApi.eval(x.OpKind, eval(x.Arg));
                case IBinaryLogicOp x:
                    return LogicOpApi.eval(x.OpKind, eval(x.LeftArg), eval(x.RightArg));
                case ITernaryLogicOp x:
                    return LogicOpApi.eval(x.OpKind, eval(x.FirstArg), eval(x.SecondArg), eval(x.ThirdArg));
                default:
                    return unhandled(expr);
            }
        }

        static bit unhandled(ILogicExpr expr)
            => throw new Exception($"{expr} unhandled");
    }

}