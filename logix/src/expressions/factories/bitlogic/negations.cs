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
    
    partial class BitLogicSpec
    {

        /// <summary>
        /// Defines the operator expression not(a) for a logic expression a
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp not(ILogicExpr a)
            => unary(UnaryLogicOpKind.Not, a);

        /// <summary>
        /// Defines the operator expression nor(a,b) := not(or(a,b)) for logic expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Nor, a, b);

        /// <summary>
        /// Defines the operator expression nor(a,b) := not(or(a,b)) for literal expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Nor, a, b);

        /// <summary>
        /// Defines the operator expression xnor(a,b) := not(xor(a,b)) for logic expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xnor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Xnor, a, b);

        /// <summary>
        /// Defines the operator expression xnor(a,b) := not(xor(a,b)) for literal expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xnor(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Xnor, a, b);

        /// <summary>
        /// Defines the operator expression nand(a,b) := not(and(a,b)) for logic expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Nand, a, b);

        /// <summary>
        /// Defines the operator expression nand(a,b) := not(and(a,b)) for literal expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Nand, a, b);

        /// <summary>
        /// Defines the operator expression and(a, not(b)) for logic expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp andnot(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.AndNot, a, b);
        
        /// <summary>
        /// Defines the operator expression and(a, not(b)) for literal expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp andnot(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.AndNot, a, b);

    }
}