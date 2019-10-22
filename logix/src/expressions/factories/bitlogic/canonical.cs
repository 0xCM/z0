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
        public static BinaryLogicOp and(LiteralLogicExpr a, LiteralLogicExpr b)
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
        public static BinaryLogicOp or(LiteralLogicExpr a, LiteralLogicExpr b)
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
        public static BinaryLogicOp xor(LiteralLogicExpr a, LiteralLogicExpr b)
            => binary(BinaryLogicOpKind.XOr, a, b);

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
        public static BinaryLogicOp nor(LiteralLogicExpr a, LiteralLogicExpr b)
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
        public static BinaryLogicOp xnor(LiteralLogicExpr a, LiteralLogicExpr b)
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
        public static BinaryLogicOp nand(LiteralLogicExpr a, LiteralLogicExpr b)
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
        public static BinaryLogicOp andnot(LiteralLogicExpr a, LiteralLogicExpr b)
            => binary(BinaryLogicOpKind.AndNot, a, b);

        /// <summary>
        /// Defines the operator expression left(a, b) for logic expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp left(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.LeftProject, a, b);

        /// <summary>
        /// Defines the operator expression left(a, b) for literal expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp left(LiteralLogicExpr a, LiteralLogicExpr b)
            => binary(BinaryLogicOpKind.LeftProject, a, b);

        /// <summary>
        /// Defines the operator expression right(a, b) for logic expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp right(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicOpKind.RightProject, a, b);

        /// <summary>
        /// Defines the operator expression right(a, b) for literal expressions a and b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp right(LiteralLogicExpr a, LiteralLogicExpr b)
            => binary(BinaryLogicOpKind.RightProject, a, b);

        /// <summary>
        /// Defines a material conditional, otherwise known as an implication operator
        /// </summary>
        /// <param name="antecedent">The first operand</param>
        /// <param name="consequent">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp implies(ILogicExpr antecedent, ILogicExpr consequent)
            => binary(BinaryLogicOpKind.Implies, antecedent, consequent);

    }
}