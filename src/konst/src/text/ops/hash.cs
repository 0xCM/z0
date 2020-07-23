//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Returns a system-provided hash code for a specified character span
        /// </summary>
        /// <param name="src">The data soruce</param>
        [MethodImpl(Inline), Op]
        public static int syshash(ReadOnlySpan<char> src)
            => string.GetHashCode(src);

        /// <summary>
        /// Returns a hash code predicated on the address of the leading character
        /// </summary>
        /// <param name="src">The data soruce</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<char> src)
            => z.hash(address(first(src)));
    }
}