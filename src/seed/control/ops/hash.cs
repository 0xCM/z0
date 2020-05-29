//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        /// <summary>
        /// The 8'th Mersene prime and the largest 32-bit prime
        /// </summary>
        /// <remarks>
        /// See https://en.wikipedia.org/wiki/2,147,483,647
        /// <remarks>
        const uint Mersene8 = 2147483647u;

        /// <summary>
        /// Completely untested hash function that may or may not be suitable for GetHashCode() implementations; it should, however, be fast
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public static int hash(ReadOnlySpan<byte> src)
        {
            var code = Mersene8;
            for(int i=0; i<src.Length; i++)
                code ^= ~(uint)skip(src,i);
            return (int)code;
        }
    }
}