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
    
    partial class BitLogicSpec
    {
       /// <summary>
        /// Defines a bit sequence expression with an arbitrary number of terms
        /// </summary>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static BitLiteralSeq bitseq(params bit[] terms)
            => BitLiteralSeq.FromBits(terms);

        /// <summary>
        /// Defines a bit sequence expression of natural length
        /// </summary>
        /// <param name="length">The natural length of the sequence</param>
        /// <param name="terms">The sequence terms</param>
        [MethodImpl(Inline)]
        public static BitLiteralSeq<N> bitseq<N>(N length, params bit[] terms)
            where N : ITypeNat, new()
                => BitLiteralSeq.FromBits(length,terms);
 
    }

}