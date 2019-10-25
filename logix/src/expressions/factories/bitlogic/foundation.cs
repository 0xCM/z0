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
        public static LiteralLogicExpr on()
            => literal(bit.On);

        /// <summary>
        /// Creates a logical FALSE expression, i.e. an expression that is always false
        /// </summary>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr off()
            => literal(bit.Off);

        /// <summary>
        /// Creates a bit literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        [MethodImpl(Inline)]
        public static LiteralLogicExpr literal(bit value)
            => new LiteralLogicExpr(value);

        /// <summary>
        /// Defines a logical identity expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp identity(ILogicExpr a)
            => unary(UnaryLogicOpKind.Identity, a);

        /// <summary>
        /// Defines a unary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp unary(UnaryLogicOpKind op, ILogicExpr operand)
            => new UnaryLogicOp(op,operand);

        /// <summary>
        /// Defines a binary logic operator
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The first operand</param>
        /// <param name="right">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp binary(BinaryLogicOpKind op, ILogicExpr left, ILogicExpr right)
            => new BinaryLogicOp(op,left,right);

        /// <summary>
        /// Defines a binary logic operator
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The first operand</param>
        /// <param name="right">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp ternary(TernaryBitOpKind op, ILogicExpr first, ILogicExpr second, ILogicExpr third)
            => new TernaryLogicOp(op,first,second,third);
    }
}