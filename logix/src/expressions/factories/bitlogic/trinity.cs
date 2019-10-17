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
    
    public static partial class BitLogicSpec
    {

        /// <summary>
        /// Defines a logical AND expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp and(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.And, a, b);

        /// <summary>
        /// Defines a logical AND expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp and(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Or, a, b);

        /// <summary>
        /// Defines a logical OR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp or(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.Or, a, b);

        /// <summary>
        /// Defines a logical OR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp or(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.Or, a, b);

        /// <summary>
        /// Defines a logical XOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.XOr, a, b);

        /// <summary>
        /// Defines a logical XOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xor(BitLiteralExpr a, BitLiteralExpr b)
            => binary(BinaryLogicOpKind.XOr, a, b);


    }
}