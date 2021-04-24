//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Deallocates a native allocation
        /// </summary>
        /// <param name="handle">The allocation handle</param>
        [MethodImpl(Inline), Op]
        public static void release(IntPtr handle)
            => Marshal.FreeHGlobal(handle);
    }
}