//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> shift<T>(ShiftOpKind op, ITypedExpr<T> src, int offset)
            where T : unmanaged
                => new ShiftOpSpec<T>(op,src,literal(offset));

        /// <summary>
        /// Creates a shift expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> shiftx<T>(ShiftOpKind op, ITypedExpr<T> src, ITypedExpr<int> offset)
            where T : unmanaged
                => new ShiftOpSpec<T>(op,src, offset);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sll<T>(ITypedExpr<T> src, int offset)
            where T : unmanaged
                => shift(ShiftOpKind.Sll, src, offset);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sll<T>(T src, int offset)
            where T : unmanaged
                => sll(literal(src), offset);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(ITypedExpr<T> src, int offset)
            where T : unmanaged
                => shift(ShiftOpKind.Srl, src, offset);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(T src, int offset)
            where T : unmanaged
                => srl(literal(src), offset);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(ITypedExpr<T> src, int offset)
            where T : unmanaged
                => shift(ShiftOpKind.Rotr, src, offset);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(T src, int offset)
            where T : unmanaged
                => rotr(literal(src), offset);
        
        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(ITypedExpr<T> src, int offset)
            where T : unmanaged
                => shift(ShiftOpKind.Rotl, src, offset);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(T src, int offset)
            where T : unmanaged
                => rotl(literal(src), offset);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sll<T>(ITypedExpr<T> src, ITypedExpr<int> offset)
            where T : unmanaged
                => shiftx(ShiftOpKind.Sll, src, offset);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> sllx<T>(T src, ITypedExpr<int> offset)
            where T : unmanaged
                => sll(literal(src), offset);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(ITypedExpr<T> src, ITypedExpr<int> offset)
            where T : unmanaged
                => shiftx(ShiftOpKind.Srl, src, offset);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> srl<T>(T src, ITypedExpr<int> offset)
            where T : unmanaged
                => srl(literal(src), offset);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(ITypedExpr<T> src, ITypedExpr<int> offset)
            where T : unmanaged
                => shiftx(ShiftOpKind.Rotr, src, offset);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotr<T>(T src, ITypedExpr<int> offset)
            where T : unmanaged
                => rotr(literal(src), offset);
        
        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(ITypedExpr<T> src, ITypedExpr<int> offset)
            where T : unmanaged
                => shiftx(ShiftOpKind.Rotl, src, offset);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="src">The left operand</param>
        /// <param name="offset">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ShiftOpSpec<T> rotl<T>(T src, ITypedExpr<int> offset)
            where T : unmanaged
                => rotl(literal(src), offset);


    }

}