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

    public static class BitLogicEval
    {
        internal static bit eval(ILogicExpr expr)
        {
            switch(expr)               
            {
                case ILogicVariable x:
                    return eval(x);
                case IVariedLogicExpr x:
                    return eval(x);
                case ILogicLiteral x:
                    return eval(x);
                case ILogicOpExpr x:
                    return eval(x);
                case IEqualityExpr x:
                    return eval(x);
                default: 
                    return unhandled(expr);
            }
        }


        /// <summary>
        /// Evaluates a logical variable expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        static bit eval(ILogicVariable expr)
            => eval(expr.Value);

        /// <summary>
        /// Evaluates a varied logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        static bit eval(IVariedLogicExpr expr)
            => eval(expr.BaseExpr as ILogicExpr);

        /// <summary>
        /// Evaluates a logical literal expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        static bit eval(ILogicLiteral expr)
            => expr.Value;

        /// <summary>
        /// Evaluates a logical operator expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        static bit eval(ILogicOpExpr expr)
        {
            switch(expr)               
            {
                case IUnaryLogicOp x:
                    return eval(x);
                case IBinaryLogicOp x:
                    return eval(x);
                case ITernaryLogicOp x:
                    return eval(x);
                default:
                    return unhandled(expr);
            }
        }

        [MethodImpl(Inline)]
        static bit eval(IEqualityExpr expr)
            => eval(expr.Lhs) == eval(expr.Rhs);

        /// <summary>
        /// Evaluates a unary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        static bit eval(IUnaryLogicOp expr)
        {
        
            switch(expr.OpKind)
            {
                case UnaryLogicOpKind.Not:
                    return bit.not(eval(expr.Operand));
                case UnaryLogicOpKind.Identity:
                    return eval(expr.Operand);
                default:
                    return unhandled(expr);
            }
        }

        /// <summary>
        /// Evaluates a binary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        static bit eval(IBinaryLogicOp expr)
        {
            switch(expr.OpKind)
            {
                case BinaryLogicOpKind.And:
                    return bit.and(eval(expr.LeftArg), eval(expr.RightArg));
                case BinaryLogicOpKind.Or:
                    return bit.or(eval(expr.LeftArg), eval(expr.RightArg));
                case BinaryLogicOpKind.XOr:
                    return bit.xor(eval(expr.LeftArg), eval(expr.RightArg));
                case BinaryLogicOpKind.Nor:
                    return bit.nor(eval(expr.LeftArg), eval(expr.RightArg));
                case BinaryLogicOpKind.Nand:
                    return bit.nand(eval(expr.LeftArg), eval(expr.RightArg));
                case BinaryLogicOpKind.Xnor:
                    return bit.xnor(eval(expr.LeftArg), eval(expr.RightArg));
                case BinaryLogicOpKind.Implies:
                    return bit.implies(eval(expr.LeftArg), eval(expr.RightArg));
                default:
                    return unhandled(expr);            
            }
        }

        /// <summary>
        /// Evaluates a ternary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        static bit eval(ITernaryLogicOp expr)
            => eval(expr.FirstArg) ? eval(expr.SecondArg) : eval(expr.ThirdArg);

        static bit unhandled(ILogicExpr expr)
            => throw new Exception($"{expr} unhandled");

    }

}