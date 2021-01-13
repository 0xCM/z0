//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using Windows;

    partial struct memory
    {
        public static unsafe BasicMemoryInfo basic()
        {
            var src = new MEMORY_BASIC_INFORMATION();
            var dst = new BasicMemoryInfo();
            VirtualQuery(&src, ref src, new IntPtr(sizeof(MEMORY_BASIC_INFORMATION)));

            dst.AllocationBase = src.AllocationBase;
            dst.BaseAddress = src.BaseAddress;
            dst.RegionSize = src.RegionSize;
            dst.StackSize = (ulong)(dst.BaseAddress - dst.AllocationBase) + dst.RegionSize;
            dst.Protection = (PageProtection)src.AllocationProtect;
            return dst;
        }

        [DllImport("kernel32")]
        static unsafe extern IntPtr VirtualQuery(void* address, ref MEMORY_BASIC_INFORMATION buffer, IntPtr length);

    }
}