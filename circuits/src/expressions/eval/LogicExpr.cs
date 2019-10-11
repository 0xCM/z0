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

    public static class LogicExpr
    {
        [MethodImpl(Inline)]
        public static Bit eval(ILogicExpr expr)
        {
            switch(expr)
            {
                case ILogicLiteralExpr x:
                    return eval(x);
                case ILogicOpExpr x:
                    return eval(x);
                case ILogicVarExpr x:
                    return eval(x);
            }
            return Bit.Off;
        }   

        /// <summary>
        /// Evaluates a logical literal expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ILogicLiteralExpr expr)
            => expr.Value;

        /// <summary>
        /// Evaluates a logical variable expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ILogicVarExpr expr)
            => eval(expr.Value);

        /// <summary>
        /// Evaluates a logical operator expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ILogicOpExpr expr)
        {
            switch(expr)               
            {
                case IUnaryLogicExpr x:
                    return eval(x);
                case IBinaryLogicExpr x:
                    return eval(x);
                case ITernaryLogicExpr x:
                    return eval(x);
            }
            return Bit.Off;
        }

        /// <summary>
        /// Evaluates a unary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        public static Bit eval(IUnaryLogicExpr expr)
        {
        
            switch(expr.Operator)
            {
                case LogicOpKind.Not:
                    return BitOps.not(eval(expr.Operand));
                case LogicOpKind.Identity:
                    return eval(expr.Operand);
            }
            return Bit.Off;
        }


        /// <summary>
        /// Evaluates a binary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        public static Bit eval(IBinaryLogicExpr expr)
        {
            switch(expr.Operator)
            {
                case LogicOpKind.And:
                    return BitOps.and(eval(expr.Left), eval(expr.Right));
                case LogicOpKind.Or:
                    return BitOps.or(eval(expr.Left), eval(expr.Right));
                case LogicOpKind.XOr:
                    return BitOps.xor(eval(expr.Left), eval(expr.Right));
                case LogicOpKind.Nor:
                    return BitOps.nor(eval(expr.Left), eval(expr.Right));
                case LogicOpKind.XNor:
                    return BitOps.xnor(eval(expr.Left), eval(expr.Right));
                case LogicOpKind.Nand:
                    return BitOps.nand(eval(expr.Left), eval(expr.Right));
                case LogicOpKind.Implies:
                    return BitOps.implies(eval(expr.Left), eval(expr.Right));

            }
            return Bit.Off;
        }

        /// <summary>
        /// Evaluates a ternary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ITernaryLogicExpr expr)
            => eval(expr.First) ? eval(expr.Second) : eval(expr.Third);

    }

}