//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        /// <summary>
        /// Addition mod 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Op]
        public static void add128(ref ulong dstHi, ref ulong dstLo, ulong src)
        {
            if ((dstLo += src) < src)
                dstHi++;
        }

        /// <summary>
        /// Addition mod 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Op]
        public static void add128(ref ulong dstHi, ref ulong dstLo, ulong srcHi, ulong srcLo)
        {
            if ((dstLo += srcLo) < srcLo)
                dstHi++;
            dstHi += srcHi;
        }
    }
}