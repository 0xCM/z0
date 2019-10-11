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

    public static class BitExprSpec
    {
        /// <summary>
        /// Creates a bit literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static BitLitExpr<T> literal<T>(T value)
            where T : unmanaged
                => new BitLitExpr<T>(value);

        /// <summary>
        /// Creates a bitwise unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> unary<T>(BitOpKind op, IBitExpr<T> operand)
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
        public static BinaryBitsExpr<T> binary<T>(BitOpKind op, IBitExpr<T> left, IBitExpr<T> right)
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
        public static TernaryBitsExpr<T> ternary<T>(BitOpKind op, IBitExpr<T> a, IBitExpr<T> b, IBitExpr<T> c)
            where T : unmanaged
                => new TernaryBitsExpr<T>(op,a,b,c);

        /// <summary>
        /// Creates a mixed bitwise expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> mixed<T>(BitOpKind op, IBitExpr<T> left, uint right)
            where T : unmanaged
                => new MixedBitsExpr<T>(op,left, literal(right));

        /// <summary>
        /// Creates a mixed bitwise expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static MixedBitsExpr<T> mixed<T>(BitOpKind op, IBitExpr<T> left, IBitExpr<uint> right)
            where T : unmanaged
                => new MixedBitsExpr<T>(op,left,right);

        /// <summary>
        /// Defines a a bitwise complement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitsExpr<T> not<T>(IBitExpr<T> operand)
            where T : unmanaged
                => unary(BitOpKind.Not, operand);

        /// <summary>
        /// Defines a a bitwise complement expression with a literal operand
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
        public static UnaryBitsExpr<T> negate<T>(IBitExpr<T> operand)
            where T : unmanaged
                => unary(BitOpKind.Negate, operand);

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
        public static BinaryBitsExpr<T> and<T>(IBitExpr<T> lhs, IBitExpr<T> rhs)
            where T : unmanaged
                => binary(BitOpKind.And, lhs,rhs);

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
        public static BinaryBitsExpr<T> or<T>(IBitExpr<T> lhs, IBitExpr<T> rhs)
            where T : unmanaged
                => binary(BitOpKind.Or, lhs,rhs);

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
        public static BinaryBitsExpr<T> xor<T>(IBitExpr<T> lhs, IBitExpr<T> rhs)
            where T : unmanaged
                => binary(BitOpKind.XOr, lhs,rhs);

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
        public static MixedBitsExpr<T> sll<T>(IBitExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixed(BitOpKind.Sll, lhs, rhs);

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
        public static MixedBitsExpr<T> srl<T>(IBitExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixed(BitOpKind.Srl, lhs, rhs);

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
        public static MixedBitsExpr<T> rotl<T>(IBitExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixed(BitOpKind.Rotl, lhs, rhs);

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
        public static MixedBitsExpr<T> rotr<T>(IBitExpr<T> lhs, uint rhs)
            where T : unmanaged
                => mixed(BitOpKind.Rotr, lhs, rhs);

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
        /// Defines a scalar range expression
        /// </summary>
        /// <param name="min">The minimum scalar in the range</param>
        /// <param name="max">The maximum scalar in the range</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static RangeExpr<T> rangexpr<T>(T min, T max)
            where T : unmanaged
                => new RangeExpr<T>(min,max);

        /// <summary>
        /// Defines a variable expression
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static BitVarExpr<T> bitvar<T>(string name, IBitExpr<T> value)
            where T : unmanaged
                => new BitVarExpr<T>(name, value);

        /// <summary>
        /// Defines a bit variable expression where the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static BitVarExpr<T> bitvar<T>(uint name, IBitExpr<T> init)
            where T : unmanaged
            => new BitVarExpr<T>(name.ToString(), init);

        /// <summary>
        /// Defines a variable expression with an initial value specified by a literal
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static BitVarExpr<T> bitvar<T>(string name, T value = default)
            where T : unmanaged
                => new BitVarExpr<T>(name, literal(value));

        /// <summary>
        /// Defines a variable expression where the variable name is defined by an integer and 
        /// an initial value is specified by a literal
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static BitVarExpr<T> bitvar<T>(uint name, T value = default)
            where T : unmanaged
                => new BitVarExpr<T>(name.ToString(), literal(value));

        
    }       


}