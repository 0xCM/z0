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
        public static bit eval(IExpr expr)
        {
            switch(expr)
            {
                case IVariedLogicExpr x:
                    return eval(x);
                case IBitLiteral x:
                    return eval(x);
                case ILogicOp x:
                    return eval(x);
                case IExpr x:
                    return eval(x);
            }
            return bit.Off;
        }   

        /// <summary>
        /// Evaluates a logical literal expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static bit eval(IBitLiteral expr)
            => expr.Value;

        /// <summary>
        /// Evaluates a logical variable expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static bit eval(ILogicVar expr)
            => eval(expr.Value);

        /// <summary>
        /// Evaluates a varied logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static bit eval(IVariedLogicExpr expr)
            => eval(expr.BaseExpr);

        /// <summary>
        /// Evaluates a logical operator expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static bit eval(ILogicOp expr)
        {
            switch(expr)               
            {
                case IUnaryLogicOp x:
                    return eval(x);
                case IBinaryLogicOp x:
                    return eval(x);
                case ITernaryLogicOp x:
                    return eval(x);
            }
            return bit.Off;
        }

        /// <summary>
        /// Evaluates a unary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        public static bit eval(IUnaryLogicOp expr)
        {
        
            switch(expr.Operator)
            {
                case UnaryLogicKind.Not:
                    return bit.not(eval(expr.Operand));
                case UnaryLogicKind.Identity:
                    return eval(expr.Operand);
            }
            return bit.Off;
        }

        public static bit eval(ILogicExpr expr)
        {
            switch(expr)               
            {
                case IBitLiteral x:
                    return x.Value;
                case ILogicVar x:
                    return eval(x.Value);
                case ILogicOp x:
                    return eval(x);
            }
            return bit.Off;

        }
        /// <summary>
        /// Evaluates a binary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        public static bit eval(IBinaryLogicOp expr)
        {
            switch(expr.Operator)
            {
                case BinaryLogicKind.And:
                    return bit.and(eval(expr.Left), eval(expr.Right));
                case BinaryLogicKind.Or:
                    return bit.or(eval(expr.Left), eval(expr.Right));
                case BinaryLogicKind.XOr:
                    return bit.xor(eval(expr.Left), eval(expr.Right));
                case BinaryLogicKind.Nor:
                    return bit.nor(eval(expr.Left), eval(expr.Right));
                case BinaryLogicKind.Xnor:
                    return bit.xnor(eval(expr.Left), eval(expr.Right));
                case BinaryLogicKind.Nand:
                    return bit.nand(eval(expr.Left), eval(expr.Right));
                case BinaryLogicKind.Implies:
                    return bit.implies(eval(expr.Left), eval(expr.Right));

            }
            return bit.Off;
        }

        /// <summary>
        /// Evaluates a ternary logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static bit eval(ITernaryLogicOp expr)
            => eval(expr.First) ? eval(expr.Second) : eval(expr.Third);

        public static bit same(VariedLogicExpr lhs, VariedLogicExpr rhs)
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

        static bit same(N1 n, VariedLogicExpr lhs, VariedLogicExpr rhs)
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

        static bit same(N2 n, VariedLogicExpr lhs, VariedLogicExpr rhs)
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

        static bit same(N3 n, VariedLogicExpr lhs, VariedLogicExpr rhs)
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