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
    
    public static class LogicExprSpec
    {
        /// <summary>
        /// Creates a bit literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        [MethodImpl(Inline)]
        public static LogicLitExpr literal(Bit value)
            => new LogicLitExpr(value);

        /// <summary>
        /// Creates a logical TRUE expression, i.e. an expression that is always true
        /// </summary>
        [MethodImpl(Inline)]
        public static LogicLitExpr on()
            => literal(Bit.On);

        /// <summary>
        /// Creates a logical FALSE expression, i.e. an expression that is always false
        /// </summary>
        [MethodImpl(Inline)]
        public static LogicLitExpr off()
            => literal(Bit.Off);

        /// <summary>
        /// Defines a unary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr unary(UnaryLogic op, ILogicExpr operand)
            => new UnaryLogicExpr(op,operand);

        /// <summary>
        /// Defines a binary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The first operand</param>
        /// <param name="right">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr binary(BinaryLogic op, ILogicExpr left, ILogicExpr right)
            => new BinaryLogicExpr(op,left,right);

        /// <summary>
        /// Defines a logical NOT expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr not(ILogicExpr a)
            => unary(UnaryLogic.Not, a);

        /// <summary>
        /// Defines a logical identity expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr identity(ILogicExpr a)
            => unary(UnaryLogic.Identity, a);

        /// <summary>
        /// Defines a logical AND expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr and(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogic.And, a, b);

        /// <summary>
        /// Defines a logical AND expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr and(LogicLitExpr a, LogicLitExpr b)
            => binary(BinaryLogic.Or, a, b);

        /// <summary>
        /// Defines a logical OR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr or(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogic.Or, a, b);

        /// <summary>
        /// Defines a logical OR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr or(LogicLitExpr a, LogicLitExpr b)
            => binary(BinaryLogic.Or, a, b);

        /// <summary>
        /// Defines a logical XOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogic.XOr, a, b);

        /// <summary>
        /// Defines a logical XOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xor(LogicLitExpr a, LogicLitExpr b)
            => binary(BinaryLogic.XOr, a, b);

        /// <summary>
        /// Defines a logical NOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogic.Nor, a, b);

        /// <summary>
        /// Defines a logical NOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nor(LogicLitExpr a, LogicLitExpr b)
            => binary(BinaryLogic.Nor, a, b);

        /// <summary>
        /// Defines a logical XNOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xnor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogic.XNor, a, b);

        /// <summary>
        /// Defines a logical XNOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xnor(LogicLitExpr a, LogicLitExpr b)
            => binary(BinaryLogic.XNor, a, b);

        /// <summary>
        /// Defines an equality expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nand(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogic.Nand, a, b);

        /// <summary>
        /// Defines a logical NAND expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nand(LogicLitExpr a, LogicLitExpr b)
            => binary(BinaryLogic.Nand, a, b);

        /// <summary>
        /// Defines a material conditional, otherwise known as an implication operator
        /// </summary>
        /// <param name="antecedent">The first operand</param>
        /// <param name="consequent">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr implies(ILogicExpr antecedent, ILogicExpr consequent)
            => binary(BinaryLogic.Implies, antecedent, consequent);

        /// <summary>
        /// Defines a bit variable expression
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVarExpr bitvar(string name, ILogicExpr init)
            => new LogicVarExpr(name,init);

        /// <summary>
        /// Defines a bit variable expression where the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVarExpr bitvar(uint name, ILogicExpr init)
            => new LogicVarExpr(name.ToString(), init);

        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVarExpr bitvar(string name, Bit init = default)
            => new LogicVarExpr(name,literal(init));

        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// and the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVarExpr bitvar(uint name, Bit init = default)
            => bitvar(name.ToString(),init);

        /// <summary>
        /// Defines a bit sequence expression with an arbitrary number of terms
        /// </summary>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static BitLogicSeq bitseq(params Bit[] terms)
            => BitLogicSeq.FromBits(terms);

        /// <summary>
        /// Defines a bit sequence expression of natural length
        /// </summary>
        /// <param name="length">The natural length of the sequence</param>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static BitLogicSeq<N> bitseq<N>(N length, params Bit[] terms)
            where N : ITypeNat, new()
                => BitLogicSeq.FromBits(length,terms);

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence
        /// </summary>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedExpr varied(ILogicExpr subject, params ILogicVarExpr[] variables)
            => VariedExpr.Define(subject, variables);

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence of natural length
        /// </summary>
        /// <param name="n">The natural length of the variable sequence</param>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedExpr<N> varied<N>(N n, ILogicExpr subject, params ILogicVarExpr[] variables)
            where N : ITypeNat, new()
                => VariedExpr.Define(n,subject, variables);

        /// <summary>
        /// Computes all bit sequence expressions of length 1
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N1>> bitcombo(N1 n)
            =>  from a in Bit.B01
                select bitseq(n, a);

        /// <summary>
        /// Computes all bit sequence expressions of length 2
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N2>> bitcombo(N2 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                select bitseq(n, a, b);

        /// <summary>
        /// Computes all bit sequence expressions of length 3
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N3>> bitcombo(N3 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                from c in Bit.B01
                select bitseq(n, a, b, c);

        /// <summary>
        /// Computes all bit sequence expressions of length 4
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N4>> bitcombo(N4 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                from c in Bit.B01
                from d in Bit.B01
                select bitseq(n, a, b, c,d);

        /// <summary>
        /// Computes all bit sequence expressions of length 5
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N5>> bitcombo(N5 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                from c in Bit.B01
                from d in Bit.B01
                from e in Bit.B01
                select bitseq(n, a, b, c,d, e);

        /// <summary>
        /// Computes all bit sequence expressions of length 6
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N6>> bitcombo(N6 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                from c in Bit.B01
                from d in Bit.B01
                from e in Bit.B01
                from f in Bit.B01
                select bitseq(n, a, b, c, d, e, f);

        /// <summary>
        /// Computes all bit sequence expressions of length 7
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N7>> bitcombo(N7 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                from c in Bit.B01
                from d in Bit.B01
                from e in Bit.B01
                from f in Bit.B01
                from g in Bit.B01
                select bitseq(n, a, b, c, d, e, f, g);

        /// <summary>
        /// Computes all bit sequence expressions of length 8
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLogicSeq<N8>> bitcombo(N8 n)
            =>  from a in Bit.B01
                from b in Bit.B01
                from c in Bit.B01
                from d in Bit.B01
                from e in Bit.B01
                from f in Bit.B01
                from g in Bit.B01
                from h in Bit.B01
                select bitseq(n, a, b, c, d, e, f, g, h);

    }

}