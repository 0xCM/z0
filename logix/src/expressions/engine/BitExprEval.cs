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

    public static class BitExprEval
    {
        public static bit eval(ILogicExpr expr)
        {
            switch(expr)               
            {
                case IlogicVariable x:
                    return eval(x);
                case IVariedLogicExpr x:
                    return eval(x);
                case IBitLiteralExpr x:
                    return eval(x);
                case ILogicOp x:
                    return eval(x);
                default: 
                    return unhandled(expr);
            }
        }

        public static bit equal(VariedLogicExpr lhs, VariedLogicExpr rhs)
        {
            var count = length(lhs.Vars, rhs.Vars);
            switch(count)
            {
                case 1:
                    return equal(n1,lhs, rhs);
                case 2:
                    return equal(n2, lhs, rhs);
                case 3:
                    return equal(n3, lhs, rhs);                
                default:
                    return Bit.Off;
            }
        }

        /// <summary>
        /// Evaluates a logical variable expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        static bit eval(IlogicVariable expr)
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
        static bit eval(IBitLiteralExpr expr)
            => expr.Value;

        /// <summary>
        /// Evaluates a logical operator expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        static bit eval(ILogicOp expr)
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

        /// <summary>
        /// Evaluates a unary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
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


        static bit equal(N1 n, VariedLogicExpr lhs, VariedLogicExpr rhs)
        {
            foreach(var seq in BitLogicSpec.bitcombo(n1))                    
            {
                var a = BitLogicSpec.literal(seq[0]);
                lhs.SetVarValues(a);
                rhs.SetVarValues(a);
                var x = eval(lhs);
                var y = eval(rhs);                        
                if(x != y)
                    return Bit.Off;
            }
            return Bit.On;

        }

        static bit equal(N2 n, VariedLogicExpr lhs, VariedLogicExpr rhs)
        {
            foreach(var seq in BitLogicSpec.bitcombo(n2))
            {
                var a = BitLogicSpec.literal(seq[0]);
                var b = BitLogicSpec.literal(seq[1]);
                lhs.SetVarValues(a,b);
                rhs.SetVarValues(a,b);
                var x = eval(lhs);
                var y = eval(rhs);                        
                if(x != y)
                    return Bit.Off;
            }
            return Bit.On;

        }

        static bit equal(N3 n, VariedLogicExpr lhs, VariedLogicExpr rhs)
        {
            foreach(var seq in BitLogicSpec.bitcombo(n3))                    
            {
                var a = BitLogicSpec.literal(seq[0]);
                var b = BitLogicSpec.literal(seq[1]);
                var c = BitLogicSpec.literal(seq[2]);
                lhs.SetVarValues(a,b,c);
                rhs.SetVarValues(a,b,c);
                var x = eval(lhs);
                var y = eval(rhs);                        
                if(x != y)
                    return Bit.Off;
            }
            return Bit.On;
        }

        static bit unhandled(ILogicExpr expr)
            => throw new Exception($"{expr} unhandled");

    }

}