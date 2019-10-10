//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Bitwise;


    partial class Bitwise
    {
        public interface IExprEval
        {

        }

        public interface IExprEval<T> : IExprEval
            where T : unmanaged
        {

        }

        public interface IExprEval<T,E> : IExprEval<T>
            where T : unmanaged
            where E : IExpr
        {

        }

        public interface IBitwiseExprEval<T,E> : IExprEval<T>
            where T : unmanaged
            where E : IBitwiseExpr
        {
            /// <summary>
            /// Evaluates a bitwise binary expression
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            E Eval(BitOpKind op, E lhs, E rhs);

            /// <summary>
            /// Evaluates a bitwise unary expression
            /// </summary>
            /// <param name="operand">The operand</param>
            E Eval(BitOpKind op, E operand);

            /// <summary>
            /// Evaulates a mixed bitwise expression
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            E Eval(BitOpKind op, E lhs, uint rhs);
        }


        public interface ILogicEval<T,E>
            where T : unmanaged
            where E : IBitLogicExpr
        {
            /// <summary>
            /// Evaluates a logical unary expression
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            Bit Eval(LogicOpKind op, E operand);

            /// <summary>
            /// Evaluates a logical binary expression
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            Bit Eval(LogicOpKind op, E lhs, E rhs);
        }

    }
}