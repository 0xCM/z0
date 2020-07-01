//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial class BitSet
    {
        /// <summary>
        /// (a,b) -> [ab]
        /// </summary>
        /// <param name="a">Source bit 0</param>
        /// <param name="b">Source bit 1</param>
        [MethodImpl(Inline), Op]
        public static duet join(single a, single b)
            =>(duet)a | ((duet)b << 1);

        /// <summary>
        /// (a,b) -> [ab]
        /// </summary>
        /// <param name="a">Source bit 0</param>
        /// <param name="b">Source bit 1</param>
        [MethodImpl(Inline), Op]
        public static triad join(single a, single b, single c)
            =>(triad)a | ((triad)b << 1) | ((triad)c << 2);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        [MethodImpl(Inline), Op]
        public static quartet join(duet a, duet b)
            =>(quartet)a | ((quartet)b << 2);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static sextet join(duet a, duet b, duet c)
            =>(sextet)a | ((sextet)b << 2) | ((sextet)c << 4);

        /// <summary>
        /// (a,b,c,d) -> [dd cc bb aa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static octet join(duet a, duet b, duet c, duet d)
            => (octet)a | ((octet)b << 2) | ((octet)c << 4) | ((octet)d << 6);

        /// <summary>
        /// (a:3, b:3, c:2) -> [cc bbb aaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static octet join(triad a, triad b, duet c)
            => (octet)a | ((octet)b << 3) | ((octet)c << 6);

        
    }
}