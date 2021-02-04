//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitLogicSpec
    {
        /// <summary>
        /// Defines a bit sequence expression with an arbitrary number of terms
        /// </summary>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static LiteralLogicSeqExpr bitseq(params bit[] terms)
            => new LiteralLogicSeqExpr(terms);

        /// <summary>
        /// Defines a bit sequence expression of natural length
        /// </summary>
        /// <param name="length">The natural length of the sequence</param>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static LiteralLogicSeqExpr<N> bitseq<N>(N length, params bit[] terms)
            where N : unmanaged, ITypeNat
        {
            return new LiteralLogicSeqExpr<N>(terms);
        }
    }
}