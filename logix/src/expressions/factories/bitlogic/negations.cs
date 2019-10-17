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
        /// Defines a logical NOT expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp not(ILogicExpr a)
            => unary(UnaryLogicOpKind.Not, a);

        /// <summary>
        /// Defines a logical NOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Nor, a, b);

        /// <summary>
        /// Defines a logical NOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Nor, a, b);


        /// <summary>
        /// Defines a logical XNOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xnor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Xnor, a, b);

        /// <summary>
        /// Defines an equality expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Nand, a, b);

        /// <summary>
        /// Defines a logical NAND expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Nand, a, b);

        /// <summary>
        /// Defines a logical XNOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xnor(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Xnor, a, b);

    }
}