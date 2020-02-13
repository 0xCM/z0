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

    [ApiHost("expr.logic.eval")]
    public static class LogicExprEval
    {
        [Op("eval_logic_expr", false)]
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
               default: throw new NotSupportedException(expr.GetType().Name);
             }
        }

        /// <summary>
        /// Evaluates a logical operator expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op("eval_logic_op", false)]
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
               default: throw new NotSupportedException(expr.GetType().Name);
            }
        }
    }

}