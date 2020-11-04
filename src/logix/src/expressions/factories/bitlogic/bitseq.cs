//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitLogicSpec
    {
        /// <summary>
        /// Defines a bit sequence expression with an arbitrary number of terms
        /// </summary>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static LiteralLogicSeqExpr bitseq(params Bit32[] terms)
            => new LiteralLogicSeqExpr(terms);

        /// <summary>
        /// Defines a bit sequence expression of natural length
        /// </summary>
        /// <param name="length">The natural length of the sequence</param>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static LiteralLogicSeqExpr<N> bitseq<N>(N length, params Bit32[] terms)
            where N : unmanaged, ITypeNat
        {
            z.insist<N>(terms.Length);
            return new LiteralLogicSeqExpr<N>(terms);
        }
    }
}