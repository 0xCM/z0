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
        /// Creates a logical FALSE expression, i.e. an expression that is always false
        /// </summary>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr @false()
            => literal(bit.Off);

        /// <summary>
        /// Creates a bit literal expression
        /// </summary>
        /// <param name="a">The literal value</param>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr literal(bit a)
            => new LiteralLogicExpr(a);

        /// <summary>
        /// Defines a logical identity expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp identity(ILogicExpr a)
            => unary(UnaryLogicOpKind.Identity, a);

        /// <summary>
        /// Defines a unary logic operator over an expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp unary(UnaryLogicOpKind op, ILogicExpr a)
            => new UnaryLogicOp(op,a);

        /// <summary>
        /// Defines a unary logic operator over a literal
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp unary(UnaryLogicOpKind kind, bit a)
            => new UnaryLogicOp(kind,literal(a));

        /// <summary>
        /// Defines a binary logic operator over expression operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp binary(BinaryLogicOpKind kind, ILogicExpr a, ILogicExpr b)
            => new BinaryLogicOp(kind,a,b);

        /// <summary>
        /// Defines a binary logic operator over literal operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp binary(BinaryLogicOpKind kind, bit a, bit b)
            => new BinaryLogicOp(kind,literal(a),literal(b));

        /// <summary>
        /// Defines a ternary logic operator over expression operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp ternary(TernaryOpKind kind, ILogicExpr a, ILogicExpr b, ILogicExpr c)
            => new TernaryLogicOp(kind,a,b,c);

        /// <summary>
        /// Defines a ternary logic operator over literal operands
        /// </summary>
        /// <param name="kind">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp ternary(TernaryOpKind kind, bit a, bit b, bit c)
            => new TernaryLogicOp(kind,literal(a),literal(b),literal(c));

    }
}