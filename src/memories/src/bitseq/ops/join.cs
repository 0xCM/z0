//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial class SmallInts
    {
        /// <summary>
        /// (a,b) -> [ab]
        /// </summary>
        /// <param name="a">Source bit 0</param>
        /// <param name="b">Source bit 1</param>
        [MethodImpl(Inline), Op]
        public static uint2 join(uint1 a, uint1 b)
            =>(uint2)a | ((uint2)b << 1);

        /// <summary>
        /// (a,b) -> [ab]
        /// </summary>
        /// <param name="a">Source bit 0</param>
        /// <param name="b">Source bit 1</param>
        [MethodImpl(Inline), Op]
        public static uint3 join(uint1 a, uint1 b, uint1 c)
            => (uint3)a | ((uint3)b << 1) | ((uint3)c << 2);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        [MethodImpl(Inline), Op]
        public static uint4 join(uint2 a, uint2 b)
            => (uint4)a | ((uint4)b << 2);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static uint6 join(uint2 a, uint2 b, uint2 c)
            => (uint6)a | ((uint6)b << 2) | ((uint6)c << 4);

        /// <summary>
        /// (a,b,c,d) -> [dd cc bb aa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static octet join(uint2 a, uint2 b, uint2 c, uint2 d)
            => (octet)a | ((octet)b << 2) | ((octet)c << 4) | ((octet)d << 6);

        /// <summary>
        /// (a:3, b:3, c:2) -> [cc bbb aaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static octet join(uint3 a, uint3 b, uint2 c)
            => (octet)a | ((octet)b << 3) | ((octet)c << 6);      
    }
}