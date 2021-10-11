//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    unsafe partial struct memory
    {
        /// <summary>
        /// Determines the address of a character string at a specified offset
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(MemoryStrings src, int index)
            => core.address(chars(src, index));

        /// <summary>
        /// Determines the address of a character string at a specified offset
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(MemoryStrings src, uint index)
            => core.address(chars(src, index));
    }
}