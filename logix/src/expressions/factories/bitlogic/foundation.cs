//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    /// <summary>
    /// Defines factories that create structures for logic over a single bit
    /// </summary>
    public static partial class BitLogicSpec
    {
        /// <summary>
        /// Creates a logical TRUE expression, i.e. an expression that is always true
        /// </summary>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr @true()
            => literal(bit.On);

        /// <summary>
        /// Creates a logical TRUE expression, i.e. an expression that is always true
        /// </summary>
        [MethodImpl(Inline)]
        static LiteralLogicExpr<T> @true<T>()
            where T : unmanaged
            => literal<T>(bit.On);

        /// <summary>
        /// Creates a logical FALSE expression, i.e. an expression that is always false
        /// </summary>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr @false()
            => literal(bit.Off);

        /// <summary>
        /// Creates a logical FALSE expression, i.e. an expression that is always false
        /// </summary>
        [MethodImpl(Inline)]
        static LiteralLogicExpr<T> @false<T>()
            where T : unmanaged
                => literal<T>(bit.Off);

        /// <summary>
        /// Creates a bit literal expression
        /// </summary>
        /// <param name="a">The literal value</param>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr literal(bit a)
            => new LiteralLogicExpr(a);

        /// <summary>
        /// Creates a typed logic literal
        /// </summary>
        /// <param name="a">The literal value</param>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr<T> literal<T>(bit a)
            where T : unmanaged
                => new LiteralLogicExpr<T>(a);

        /// <summary>
        /// Defines a logical identity expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp identity(ILogicExpr a)
            => unary(UnaryBitLogicKind.Identity, a);

        /// <summary>
        /// Defines a typed logical identity expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> identity<T>(ILogicExpr<T> a)
            where T : unmanaged
                => unary(UnaryBitLogicKind.Identity, a);

        /// <summary>
        /// Defines a unary logic operator over an expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp unary(UnaryBitLogicKind op, ILogicExpr a)
            => new UnaryLogicOp(op,a);

        /// <summary>
        /// Defines a unary logic operator over an expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> unary<T>(UnaryBitLogicKind op, ILogicExpr<T> a)
            where T : unmanaged
                => new UnaryLogicOp<T>(op,a);

        /// <summary>
        /// Defines a unary logic operator over a typed literal operand
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        static UnaryLogicOp<T> unary<T>(UnaryBitLogicKind op, bit a)
            where T : unmanaged
                => new UnaryLogicOp<T>(op,literal<T>(a));

        /// <summary>
        /// Defines a unary logic operator over a literal
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp unary(UnaryBitLogicKind kind, bit a)
            => new UnaryLogicOp(kind,literal(a));

        /// <summary>
        /// Defines a binary logic operator over expression operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp binary(BinaryBitLogicKind kind, ILogicExpr a, ILogicExpr b)
            => new BinaryLogicOp(kind,a,b);

        /// <summary>
        /// Defines a binary logic operator over typed expression operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> binary<T>(BinaryBitLogicKind kind, ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => new BinaryLogicOp<T>(kind,a,b);

        /// <summary>
        /// Defines a binary logic operator over bit literal operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp binary(BinaryBitLogicKind kind, bit a, bit b)
            => new BinaryLogicOp(kind,literal(a),literal(b));

        /// <summary>
        /// Defines a binary logic operator over typed literal operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> binary<T>(BinaryBitLogicKind kind, bit a, bit b)
            where T : unmanaged
                => new BinaryLogicOp<T>(kind,literal<T>(a),literal<T>(b));

        /// <summary>
        /// Defines a ternary logic operator over expression operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp ternary(TernaryBitLogicKind kind, ILogicExpr a, ILogicExpr b, ILogicExpr c)
            => new TernaryLogicOp(kind,a,b,c);

        /// <summary>
        /// Defines a ternary logic operator over expression operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp<T> ternary<T>(TernaryBitLogicKind kind, ILogicExpr<T> a, ILogicExpr<T> b, ILogicExpr<T> c)
            where T : unmanaged
                => new TernaryLogicOp<T>(kind,a,b,c);

        /// <summary>
        /// Defines a ternary logic operator over bit literal operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp ternary(TernaryBitLogicKind kind, bit a, bit b, bit c)
            => new TernaryLogicOp(kind,literal(a),literal(b),literal(c));

        /// <summary>
        /// Defines a ternary logic operator over typed literal operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        static TernaryLogicOp<T> ternary<T>(TernaryBitLogicKind kind, bit a, bit b, bit c)
            where T : unmanaged
                => new TernaryLogicOp<T>(kind,literal<T>(a),literal<T>(b),literal<T>(c));
    }
}