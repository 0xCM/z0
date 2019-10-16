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
        public static LiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => new LiteralExpr<T>(value);

        /// <summary>
        /// Creates a bitwise unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> unary<T>(UnaryLogicKind op, IExpr<T> operand)
            where T : unmanaged
                => new UnaryLogicExpr<T>(op,operand);


        /// <summary>
        /// Creates a bitwise binary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> binary<T>(BinaryLogicKind op, IExpr<T> left, IExpr<T> right)
            where T : unmanaged
                => new BinaryLogicExpr<T>(op,left,right);

        /// <summary>
        /// Creates a bitwise ternary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryLogicExpr<T> ternary<T>(TernaryLogicKind op, ILogicExpr<T> a, ILogicExpr<T> b, ILogicExpr<T> c)
            where T : unmanaged
                => new TernaryLogicExpr<T>(op,a,b,c);


        /// <summary>
        /// Defines a a bitwise complement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> not<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicKind.Not, operand);

        /// <summary>
        /// Defines a a bitwise complement expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> not<T>(T operand)
            where T : unmanaged
                => not(literal(operand));

        /// <summary>
        /// Defines a bitwise negate expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> negate<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicKind.Negate, operand);

        /// <summary>
        /// Defines a btwise negation expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> negate<T>(T operand)
            where T : unmanaged
                => negate(literal(operand));

        /// <summary>
        /// Defines a unary increment expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> inc<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicKind.Inc, operand);

        /// <summary>
        /// Defines a unary increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> inc<T>(T operand)
            where T : unmanaged
                => inc(literal(operand));

        /// <summary>
        /// Defines a unary decrement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> dec<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicKind.Dec, operand);

        /// <summary>
        /// Defines a decrement increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr<T> dec<T>(T operand)
            where T : unmanaged
                => dec(literal(operand));

        /// <summary>
        /// Defines a bitwise and expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> and<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicKind.And, lhs,rhs);

        /// <summary>
        /// Defines a bitwise and expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> and<T>(T lhs, T rhs)
            where T : unmanaged
                => and(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise or expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> or<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicKind.Or, lhs,rhs);

        /// <summary>
        /// Defines a bitwise or expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> or<T>(T lhs, T rhs)
            where T : unmanaged
                => or(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise xor expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> xor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicKind.XOr, lhs,rhs);

        /// <summary>
        /// Defines a bitwise xor expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr<T> xor<T>(T lhs, T rhs)
            where T : unmanaged
                => xor(literal(lhs), literal(rhs));

        /// <summary>
        /// Creates a mixed bitwise expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> shift<T>(ShiftOpKind op, IExpr<T> left, int right)
            where T : unmanaged
                => new BitShiftExpr<T>(op,left, literal(right));

        /// <summary>
        /// Creates a mixed bitwise expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> shift<T>(ShiftOpKind op, IExpr<T> left, IExpr<int> right)
            where T : unmanaged
                => new BitShiftExpr<T>(op,left,right);

        /// <summary>
        /// Defines a bitwise sll expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> sll<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Sll, lhs, rhs);

        /// <summary>
        /// Defines a bitwise sll expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> sll<T>(T lhs, int rhs)
            where T : unmanaged
                => sll(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise srl expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> srl<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Srl, lhs, rhs);

        /// <summary>
        /// Defines a bitwise srl expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> srl<T>(T lhs, int rhs)
            where T : unmanaged
                => srl(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise rotl expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> rotl<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Rotl, lhs, rhs);

        /// <summary>
        /// Defines a bitwise rotl expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> rotl<T>(T lhs, int rhs)
            where T : unmanaged
                => rotl(literal(lhs), rhs);

        /// <summary>
        /// Defines a bitwise rotr expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> rotr<T>(IExpr<T> lhs, int rhs)
            where T : unmanaged
                => shift(ShiftOpKind.Rotr, lhs, rhs);

        /// <summary>
        /// Defines a bitwise rotr expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BitShiftExpr<T> rotr<T>(T lhs, int rhs)
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
        public static VarExpr<T> bitvar<T>(string name, IExpr<T> value)
            where T : unmanaged
                => new VarExpr<T>(name, value);

        /// <summary>
        /// Defines a bit variable expression where the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static VarExpr<T> bitvar<T>(uint name, IExpr<T> init)
            where T : unmanaged
            => new VarExpr<T>(name.ToString(), init);

        /// <summary>
        /// Defines a variable expression with an initial value specified by a literal
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static VarExpr<T> bitvar<T>(string name, T value = default)
            where T : unmanaged
                => new VarExpr<T>(name, literal(value));

        /// <summary>
        /// Defines a variable expression where the variable name is defined by an integer and 
        /// an initial value is specified by a literal
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static VarExpr<T> bitvar<T>(uint name, T value = default)
            where T : unmanaged
                => new VarExpr<T>(name.ToString(), literal(value));        
    }       
}