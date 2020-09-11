//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using BSK = BitShiftOpId;

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
        public static ShiftOpExpr<T> shift<T>(BSK op, IExpr<T> src, byte count)
            where T : unmanaged
                => new ShiftOpExpr<T>(op,src,literal(count));

        /// <summary>
        /// Creates a shift expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> shiftx<T>(BSK op, IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => new ShiftOpExpr<T>(op,src, count);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> sll<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(BSK.Sll, src, count);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> sll<T>(T src, byte count)
            where T : unmanaged
                => shift(BSK.Sll,literal(src), count);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> srl<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(BSK.Srl, src, count);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> srl<T>(T src, byte count)
            where T : unmanaged
                => shift(BSK.Srl,literal(src), count);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotr<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(BSK.Rotr, src, count);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotr<T>(T src, byte count)
            where T : unmanaged
                => shift(BSK.Rotr,literal(src), count);

        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotl<T>(IExpr<T> src, byte count)
            where T : unmanaged
                => shift(BSK.Rotl, src, count);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotl<T>(T src, byte count)
            where T : unmanaged
                => shift(BSK.Rotl,literal(src), count);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> sll<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Sll, src, count);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> sllx<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => sll(literal(src), count);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> srl<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Srl, src, count);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> srl<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Srl, literal(src), count);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotr<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Rotr, src, count);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotr<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Rotr, literal(src), count);

        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotl<T>(IExpr<T> src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Rotl, src, count);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="count">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpExpr<T> rotl<T>(T src, IExpr<byte> count)
            where T : unmanaged
                => shiftx(BSK.Rotl, literal(src), count);
    }
}