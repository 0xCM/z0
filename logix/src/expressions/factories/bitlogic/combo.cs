//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    partial class BitLogicSpec
    {
       /// <summary>
       /// Computes all bit sequence expressions of length n <= 8
       /// </summary>
       public static IEnumerable<LiteralLogicSeqExpr> bitcombo(int n)
       {
           switch(n)
           {
                case 1:
                {
                    return 
                        from a in bit.B01
                        select bitseq(a);
                }
                case 2:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        select bitseq(a,b);
                }
                case 3:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        from c in bit.B01
                        select bitseq(a,b,c);
                }
                case 4:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        from c in bit.B01
                        from d in bit.B01
                        select bitseq(a,b,c,d);
                }
                case 5:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        from c in bit.B01
                        from d in bit.B01
                        from e in bit.B01
                        select bitseq(a,b,c,d,e);
                }
                case 6:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        from c in bit.B01
                        from d in bit.B01
                        from e in bit.B01
                        from f in bit.B01
                        select bitseq(a,b,c,d,e,f);
                }
                case 7:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        from c in bit.B01
                        from d in bit.B01
                        from e in bit.B01
                        from f in bit.B01
                        from g in bit.B01
                        select bitseq(a,b,c,d,e,f,g);
                }
                case 8:
                {
                    return 
                        from a in bit.B01
                        from b in bit.B01
                        from c in bit.B01
                        from d in bit.B01
                        from e in bit.B01
                        from f in bit.B01
                        from g in bit.B01
                        from h in bit.B01
                        select bitseq(a,b,c,d,e,f,g,h);
                }
                default:
                    return new LiteralLogicSeqExpr[0]{};
           }
        
       }
       
        /// <summary>
        /// Computes all bit sequence expressions of length 1
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<LiteralLogicSeqExpr<N1>> bitcombo(N1 n)
            =>  from a in bit.B01
                select bitseq(n, a);

        /// <summary>
        /// Computes all bit sequence expressions of length 2
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<LiteralLogicSeqExpr<N2>> bitcombo(N2 n)
            =>  from a in bit.B01
                from b in bit.B01
                select bitseq(n, a, b);

        /// <summary>
        /// Computes all bit sequence expressions of length 3
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<LiteralLogicSeqExpr<N3>> bitcombo(N3 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                select bitseq(n, a, b, c);

        /// <summary>
        /// Computes all bit sequence expressions of length 4
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<LiteralLogicSeqExpr<N4>> bitcombo(N4 n)
            =>  from a in bit.B01
                from b in bit.B01
                from c in bit.B01
                from d in bit.B01
                select bitseq(n, a, b, c,d);

        /// <summary>
        /// Computes all bit sequence expressions of length 5
        /// </summary>
        /// <param name="n">The natural selector</param>
        public static IEnumerable<LiteralLogicSeqExpr<N5>> bitcombo(N5 n)
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
        public static IEnumerable<LiteralLogicSeqExpr<N6>> bitcombo(N6 n)
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
        public static IEnumerable<LiteralLogicSeqExpr<N7>> bitcombo(N7 n)
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
        public static IEnumerable<LiteralLogicSeqExpr<N8>> bitcombo(N8 n)
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