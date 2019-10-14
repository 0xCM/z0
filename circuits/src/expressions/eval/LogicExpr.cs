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
        /// <summary>
        /// Evaluates any logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ILogicExpr expr)
        {
            switch(expr)
            {
                case ILogicLitExpr x:
                    return eval(x);
                case ILogicOpExpr x:
                    return eval(x);
                case ILogicVarExpr x:
                    return eval(x);
                case IVariedLogicExpr x:
                    return eval(x);
            }
            return Bit.Off;
        }   

        /// <summary>
        /// Evaluates a logical literal expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ILogicLitExpr expr)
            => expr.Value;

        /// <summary>
        /// Evaluates a logical variable expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(ILogicVarExpr expr)
            => eval(expr.Value);

        /// <summary>
        /// Evaluates a varied logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static Bit eval(IVariedLogicExpr expr)
            => eval(expr.BaseExpr);

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
                case UnaryLogic.Not:
                    return BitOps.not(eval(expr.Subject));
                case UnaryLogic.Identity:
                    return eval(expr.Subject);
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
                case BinaryLogic.And:
                    return BitOps.and(eval(expr.Left), eval(expr.Right));
                case BinaryLogic.Or:
                    return BitOps.or(eval(expr.Left), eval(expr.Right));
                case BinaryLogic.XOr:
                    return BitOps.xor(eval(expr.Left), eval(expr.Right));
                case BinaryLogic.Nor:
                    return BitOps.nor(eval(expr.Left), eval(expr.Right));
                case BinaryLogic.XNor:
                    return BitOps.xnor(eval(expr.Left), eval(expr.Right));
                case BinaryLogic.Nand:
                    return BitOps.nand(eval(expr.Left), eval(expr.Right));
                case BinaryLogic.Implies:
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

        public static Bit same(VariedExpr lhs, VariedExpr rhs)
        {
            var count = length(lhs.Vars, rhs.Vars);
            switch(count)
            {
                case 1:
                    return same(n1,lhs, rhs);
                case 2:
                    return same(n2, lhs, rhs);
                case 3:
                    return same(n3, lhs, rhs);                
                default:
                    return Bit.Off;
            }

        }

        static Bit same(N1 n, VariedExpr lhs, VariedExpr rhs)
        {
            foreach(var seq in LogicExprSpec.bitcombo(n1))                    
            {
                var a = LogicExprSpec.literal(seq[0]);
                lhs.SetVarValues(a);
                rhs.SetVarValues(a);
                var x = eval(lhs);
                var y = eval(rhs);                        
                if(x != y)
                    return Bit.Off;
            }
            return Bit.On;

        }

        static Bit same(N2 n, VariedExpr lhs, VariedExpr rhs)
        {
            foreach(var seq in LogicExprSpec.bitcombo(n2))
            {
                var a = LogicExprSpec.literal(seq[0]);
                var b = LogicExprSpec.literal(seq[1]);
                lhs.SetVarValues(a,b);
                rhs.SetVarValues(a,b);
                var x = eval(lhs);
                var y = eval(rhs);                        
                if(x != y)
                    return Bit.Off;
            }
            return Bit.On;

        }

        static Bit same(N3 n, VariedExpr lhs, VariedExpr rhs)
        {
            foreach(var seq in LogicExprSpec.bitcombo(n3))                    
            {
                var a = LogicExprSpec.literal(seq[0]);
                var b = LogicExprSpec.literal(seq[1]);
                var c = LogicExprSpec.literal(seq[2]);
                lhs.SetVarValues(a,b,c);
                rhs.SetVarValues(a,b,c);
                var x = eval(lhs);
                var y = eval(rhs);                        
                if(x != y)
                    return Bit.Off;
            }
            return Bit.On;

        }


    }

}