// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Defines a memory reference
        /// </summary>
        /// <param name="address">The address</param>
        /// <param name="size">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static MemRef memref(MemoryAddress address, ByteSize size)
            => new MemRef(address,size);
    }
}