//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    //[ApiHost("expr.logic.eval",ApiHostKind.Direct)]
    public static class LogicExprEval
    {
        [Op("eval_logic_expr")]
        internal static bit eval(ILogicExpr expr)
        {
            switch(expr)               
            {
                case ILogicVarExpr x:
                    return eval(x.Value);
                case IVariedLogicExpr x:
                    return eval(x.BaseExpr);
                case ILogicLiteralExpr x:
                    return x.Value;
                case ILogicOpExpr x:
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
        [Op("eval_logic_op")]
        static bit eval(ILogicOpExpr expr)
        {
            switch(expr)               
            {
                case IUnaryLogicOpExpr x:
                    return BitLogix.Service.Evaluate(x.OpKind, eval(x.Arg));
                case IBinaryLogicOpExpr x:
                    return BitLogix.eval(x.OpKind, eval(x.LeftArg), eval(x.RightArg));
                case ITernaryLogicOpExpr x:
                    return BitLogix.eval(x.OpKind, eval(x.FirstArg), eval(x.SecondArg), eval(x.ThirdArg));
               default: throw new NotSupportedException(expr.GetType().Name);
            }
        }
    }
}