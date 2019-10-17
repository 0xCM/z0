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

    partial class TypedLogicSpec
    {
        /// <summary>
        /// Creates a shift expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> shift<T>(ShiftOpKind op, IExpr<T> left, int right)
            where T : unmanaged
                => new BitShiftOp<T>(op,left, literal(right));

        /// <summary>
        /// Creates a shift expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> shift<T>(ShiftOpKind op, IExpr<T> left, IExpr<int> right)
            where T : unmanaged
                => new BitShiftOp<T>(op,left,right);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> sll<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Sll, lhs, rhs);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> sll<T>(T lhs, int rhs)
            where T : unmanaged
                => sll(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> srl<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Srl, lhs, rhs);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> srl<T>(T lhs, int rhs)
            where T : unmanaged
                => srl(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> rotr<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Rotr, lhs, rhs);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> rotr<T>(T lhs, int rhs)
            where T : unmanaged
                => rotr(literal(lhs), rhs);
        
        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> rotl<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Rotl, lhs, rhs);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftOp<T> rotl<T>(T lhs, int rhs)
            where T : unmanaged
                => rotl(literal(lhs), rhs);



    }

}