//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    partial struct sys
    {
        public static SystemInfo sysinfo()
        {
            var src = new SYSTEM_INFO();
            Kernel32.GetSystemInfo(ref src);
            var dst = new SystemInfo();
            dst.PageSize = src.dwPageSize;
            dst.Granularity = src.dwAllocationGranularity;
            dst.MinAppAddress = src.lpMinimumApplicationAddress;
            dst.MaxAppAddress= src.lpMaximumApplicationAddress;
            return dst;
        }

        [Op]
        public static ulong pagesize()
        {
            var dst = new SYSTEM_INFO();
            Kernel32.GetSystemInfo(ref dst);
            return dst.dwPageSize;
        }

        [Op]
        public static unsafe StackExtents GetStackExtents()
        {
            var info = new MEMORY_BASIC_INFORMATION();
            Kernel32.VirtualQuery(&info, ref info, new UIntPtr((uint)sizeof(MEMORY_BASIC_INFORMATION)));
            var @base = info.AllocationBase;
            var size = (ulong)(info.BaseAddress - info.AllocationBase) + info.RegionSize;
            return new StackExtents(@base,size);
        }
    }
}