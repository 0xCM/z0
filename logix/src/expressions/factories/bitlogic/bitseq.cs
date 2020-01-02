//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    partial class BitLogicSpec
    {
        /// <summary>
        /// Defines a bit sequence expression with an arbitrary number of terms
        /// </summary>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static LiteralLogicSeq bitseq(params bit[] terms)
            => new LiteralLogicSeq(terms);

        /// <summary>
        /// Defines a bit sequence expression of natural length
        /// </summary>
        /// <param name="length">The natural length of the sequence</param>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static LiteralLogicSeq<N> bitseq<N>(N length, params bit[] terms)
            where N : unmanaged, ITypeNat
        {
            Nat.require<N>(terms.Length);
            return new LiteralLogicSeq<N>(terms);
        }
    }
}