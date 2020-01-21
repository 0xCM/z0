//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
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
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> shift<T>(ShiftOpKind op, IExpr<T> src, byte count)
            where T : unmanaged
                => new ShiftOpSpec<T>(op,src,literal(count));

        /// <summary>
        /// Creates a shift expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> shiftx<T>(ShiftOpKind op, IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => new ShiftOpSpec<T>(op,src, count);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sll<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(ShiftOpKind.Sll, src, count);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sll<T>(T src, byte count)
            where T : unmanaged
                => sll(literal(src), count);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(ShiftOpKind.Srl, src, count);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(T src, byte count)
            where T : unmanaged
                => srl(literal(src), count);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(ShiftOpKind.Rotr, src, count);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(T src, byte count)
            where T : unmanaged
                => rotr(literal(src), count);
        
        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(ShiftOpKind.Rotl, src, count);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(T src, byte count)
            where T : unmanaged
                => rotl(literal(src), count);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sll<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(ShiftOpKind.Sll, src, count);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sllx<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => sll(literal(src), count);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(ShiftOpKind.Srl, src, count);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => srl(literal(src), count);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(ShiftOpKind.Rotr, src, count);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => rotr(literal(src), count);
        
        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(ShiftOpKind.Rotl, src, count);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => rotl(literal(src), count);


    }

}