//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Bitwise
    {
        /// <summary>
        /// Creates a bitwise unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> unaryxpr<T>(BitOpKind op, IBitwiseExpr<T> operand)
            where T : unmanaged
                => new UnaryBitsExpr<T>(op,operand);

        /// <summary>
        /// Creates a bitwise binary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> binaryxpr<T>(BitOpKind op, IBitwiseExpr<T> left, IBitwiseExpr<T> right)
            where T : unmanaged
                => new BinaryBitsExpr<T>(op,left,right);

        /// <summary>
        /// Creates a bitwise ternary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryExpr<T> ternaryxpr<T>(BitOpKind op, IBitwiseExpr<T> a, IBitwiseExpr<T> b, IBitwiseExpr<T> c)
            where T : unmanaged
                => new TernaryExpr<T>(op,a,b,c);

        /// <summary>
        /// Creates a mixed bitwise expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> mixedxpr<T>(BitOpKind op, IBitwiseExpr<T> left, uint right)
            where T : unmanaged
                => new MixedBitsExpr<T>(op,left,right);

        /// <summary>
        /// Creates a literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => new LiteralExpr<T>(value);

        /// <summary>
        /// Defines a binary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> logicxpr<T>(LogicOpKind op, IBitwiseExpr<T> left, IBitwiseExpr<T> right)
            where T : unmanaged
                => new BinaryLogicExpr<T>(op,left,right);

        /// <summary>
        /// Defines a unary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> logicxpr<T>(LogicOpKind op, IBitwiseExpr<T> operand)
            where T : unmanaged
                => new UnaryLogicExpr<T>(op,operand);

        /// <summary>
        /// Defines a btwise flip expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> not<T>(IBitwiseExpr<T> operand)
            where T : unmanaged
                => unaryxpr(BitOpKind.Not, operand);

        /// <summary>
        /// Defines a btwise flip expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> not<T>(T operand)
            where T : unmanaged
                => not(literal(operand));

        /// <summary>
        /// Defines a bitwise negate expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> negate<T>(IBitwiseExpr<T> operand)
            where T : unmanaged
                => unaryxpr(BitOpKind.Negate, operand);

        /// <summary>
        /// Defines a btwise negation expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> negate<T>(T operand)
            where T : unmanaged
                => negate(literal(operand));

        /// <summary>
        /// Defines a bitwise and expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> and<T>(IBitwiseExpr<T> lhs, IBitwiseExpr<T> rhs)
            where T : unmanaged
                => binaryxpr(BitOpKind.And, lhs,rhs);

        /// <summary>
        /// Defines a bitwise and expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> and<T>(T lhs, T rhs)
            where T : unmanaged
                => and(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise or expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> or<T>(IBitwiseExpr<T> lhs, IBitwiseExpr<T> rhs)
            where T : unmanaged
                => binaryxpr(BitOpKind.Or, lhs,rhs);

        /// <summary>
        /// Defines a bitwise or expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> or<T>(T lhs, T rhs)
            where T : unmanaged
                => or(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise xor expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> xor<T>(IBitwiseExpr<T> lhs, IBitwiseExpr<T> rhs)
            where T : unmanaged
                => binaryxpr(BitOpKind.XOr, lhs,rhs);

        /// <summary>
        /// Defines a bitwise xor expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitsExpr<T> xor<T>(T lhs, T rhs)
            where T : unmanaged
                => xor(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> sll<T>(IBitwiseExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixedxpr(BitOpKind.Sll, lhs, rhs);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> sll<T>(T lhs, uint rhs)
            where T : unmanaged
                => sll(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> srl<T>(IBitwiseExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixedxpr(BitOpKind.Srl, lhs, rhs);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> srl<T>(T lhs, uint rhs)
            where T : unmanaged
                => srl(literal(lhs), rhs);
 
        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> rotl<T>(IBitwiseExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixedxpr(BitOpKind.Rotl, lhs, rhs);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> rotl<T>(T lhs, uint rhs)
            where T : unmanaged
                => rotl(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> rotr<T>(IBitwiseExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixedxpr(BitOpKind.Rotr, lhs, rhs);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> rotr<T>(T lhs, uint rhs)
            where T : unmanaged
                => rotr(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise equality comparison expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> eq<T>(IBitwiseExpr<T> lhs, IBitwiseExpr<T> rhs)
            where T : unmanaged
                =>  logicxpr(LogicOpKind.Eq, lhs, rhs);

        /// <summary>
        /// Defines a bitwise equality comparison expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> eq<T>(T lhs, T rhs)
            where T : unmanaged
                =>  eq(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise non-equality comparison expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> neq<T>(IBitwiseExpr<T> lhs, IBitwiseExpr<T> rhs)
            where T : unmanaged
                =>  logicxpr(LogicOpKind.NEq, lhs, rhs);


        /// <summary>
        /// Defines a bitwise non-equality comparison expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> neq<T>(T lhs, T rhs)
            where T : unmanaged
                =>  neq(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a test expression for a binary operator
        /// </summary>
        /// <param name="test">The logical operator to use for the test</param>
        /// <param name="control">The control expression</param>
        /// <param name="subject">The test subject</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryTestExpr<T> testxpr<T>(LogicOpKind test, Expr<T> control, BinaryBitsExpr<T> subject)
            where T : unmanaged
                => new BinaryTestExpr<T>(test,control,subject);

        /// <summary>
        /// Defines a test expression for a unary operator
        /// </summary>
        /// <param name="test">The logical operator to use for the test</param>
        /// <param name="control">The control expression</param>
        /// <param name="subject">The test subject</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryTestExpr<T> testxpr<T>(LogicOpKind test, Expr<T> control, UnaryBitsExpr<T> subject)
            where T : unmanaged
                => new UnaryTestExpr<T>(test,control,subject);

        /// <summary>
        /// Defines a test expression for a mixed operator
        /// </summary>
        /// <param name="test">The logical operator to use for the test</param>
        /// <param name="control">The control expression</param>
        /// <param name="subject">The test subject</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedTestExpr<T> testxpr<T>(LogicOpKind test, Expr<T> control, MixedBitsExpr<T> subject)
            where T : unmanaged
                => new MixedTestExpr<T>(test,control,subject);
        
        /// <summary>
        /// Defines a scalar range expression
        /// </summary>
        /// <param name="min">The minimum scalar in the range</param>
        /// <param name="max">The maximum scalar in the range</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static RangeExpr<T> rangexpr<T>(T min, T max)
            where T : unmanaged
                => new RangeExpr<T>(min,max);
    



        
    }

}