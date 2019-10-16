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
        public static BitLiteral literal(Bit value)
            => new BitLiteral(value);

        /// <summary>
        /// Creates a logical TRUE expression, i.e. an expression that is always true
        /// </summary>
        [MethodImpl(Inline)]
        public static BitLiteral on()
            => literal(Bit.On);

        /// <summary>
        /// Creates a logical FALSE expression, i.e. an expression that is always false
        /// </summary>
        [MethodImpl(Inline)]
        public static BitLiteral off()
            => literal(Bit.Off);

        /// <summary>
        /// Defines a unary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr unary(UnaryLogicKind op, ILogicExpr operand)
            => new UnaryLogicExpr(op,operand);

        /// <summary>
        /// Defines a binary logic expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The first operand</param>
        /// <param name="right">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr binary(BinaryLogicKind op, ILogicExpr left, ILogicExpr right)
            => new BinaryLogicExpr(op,left,right);

        /// <summary>
        /// Defines a logical NOT expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr not(ILogicExpr a)
            => unary(UnaryLogicKind.Not, a);

        /// <summary>
        /// Defines a logical identity expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicExpr identity(ILogicExpr a)
            => unary(UnaryLogicKind.Identity, a);

        /// <summary>
        /// Defines a logical AND expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr and(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicKind.And, a, b);

        /// <summary>
        /// Defines a logical AND expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr and(BitLiteral a, BitLiteral b)
            => binary(BinaryLogicKind.Or, a, b);

        /// <summary>
        /// Defines a logical OR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr or(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicKind.Or, a, b);

        /// <summary>
        /// Defines a logical OR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr or(BitLiteral a, BitLiteral b)
            => binary(BinaryLogicKind.Or, a, b);

        /// <summary>
        /// Defines a logical XOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicKind.XOr, a, b);

        /// <summary>
        /// Defines a logical XOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xor(BitLiteral a, BitLiteral b)
            => binary(BinaryLogicKind.XOr, a, b);

        /// <summary>
        /// Defines a logical NOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicKind.Nor, a, b);

        /// <summary>
        /// Defines a logical NOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nor(BitLiteral a, BitLiteral b)
            => binary(BinaryLogicKind.Nor, a, b);

        /// <summary>
        /// Defines a logical XNOR expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xnor(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicKind.Xnor, a, b);

        /// <summary>
        /// Defines a logical XNOR expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr xnor(BitLiteral a, BitLiteral b)
            => binary(BinaryLogicKind.Xnor, a, b);

        /// <summary>
        /// Defines an equality expression
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nand(ILogicExpr a, ILogicExpr b)
            => binary(BinaryLogicKind.Nand, a, b);

        /// <summary>
        /// Defines a logical NAND expression between literals
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr nand(BitLiteral a, BitLiteral b)
            => binary(BinaryLogicKind.Nand, a, b);

        /// <summary>
        /// Defines a material conditional, otherwise known as an implication operator
        /// </summary>
        /// <param name="antecedent">The first operand</param>
        /// <param name="consequent">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicExpr implies(ILogicExpr antecedent, ILogicExpr consequent)
            => binary(BinaryLogicKind.Implies, antecedent, consequent);


        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVar bitvar(string name, Bit init = default)
            => new LogicVar(name,literal(init));

        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// and the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVar bitvar(uint name, Bit init = default)
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
        public static VariedLogicExpr varied(IExpr subject, params ILogicVar[] variables)
            => VariedLogicExpr.Define(subject, variables);

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence of natural length
        /// </summary>
        /// <param name="n">The natural length of the variable sequence</param>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedExpr<N> varied<N>(N n, IExpr subject, params ILogicVar[] variables)
            where N : ITypeNat, new()
                => VariedLogicExpr.Define(n,subject, variables);

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