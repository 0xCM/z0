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
        /// Computes all bit sequence expressions of length 1
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N1>> bitcombo(N1 n)
            =>  from a in bit.B01
                select bitseq(n, a);

        /// <summary>
        /// Computes all bit sequence expressions of length 2
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N2>> bitcombo(N2 n)
            =>  from a in bit.B01
                from b in bit.B01
                select bitseq(n, a, b);

        /// <summary>
        /// Computes all bit sequence expressions of length 3
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N3>> bitcombo(N3 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                select bitseq(n, a, b, c);

        /// <summary>
        /// Computes all bit sequence expressions of length 4
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N4>> bitcombo(N4 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                from d in bit.B01
                select bitseq(n, a, b, c,d);

        /// <summary>
        /// Computes all bit sequence expressions of length 5
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N5>> bitcombo(N5 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                from d in bit.B01
                from e in bit.B01
                select bitseq(n, a, b, c,d, e);

        /// <summary>
        /// Computes all bit sequence expressions of length 6
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N6>> bitcombo(N6 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                from d in bit.B01
                from e in bit.B01
                from f in bit.B01
                select bitseq(n, a, b, c, d, e, f);

        /// <summary>
        /// Computes all bit sequence expressions of length 7
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N7>> bitcombo(N7 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                from d in bit.B01
                from e in bit.B01
                from f in bit.B01
                from g in bit.B01
                select bitseq(n, a, b, c, d, e, f, g);

        /// <summary>
        /// Computes all bit sequence expressions of length 8
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<BitLiteralSeq<N8>> bitcombo(N8 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                from d in bit.B01
                from e in bit.B01
                from f in bit.B01
                from g in bit.B01
                from h in bit.B01
                select bitseq(n, a, b, c, d, e, f, g, h);
    }

}