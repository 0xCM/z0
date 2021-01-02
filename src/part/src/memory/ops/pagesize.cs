//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    partial struct memory
    {
        /// <summary>
        /// Returns the page allocation size reported by the system
        /// </summary>
        [Op]
        public static ByteSize pagesize()
        {
            var dst = new SYSTEM_INFO();
            Kernel32.GetSystemInfo(ref dst);
            return dst.dwPageSize;
        }
    }
}