//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Hashes an address, perfectly
        /// </summary>
        /// <param name="count">The number of address the the perfect hash bucket</param>
        /// <param name="src">The address to hash</param>
        [MethodImpl(Inline), Op]
        public static uint hash(uint count, MemoryAddress src)
            => (uint)((ulong)src % (ulong)count);
    }
}