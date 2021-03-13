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
        public static SystemMemoryInfo system()
        {
            var src = new SYSTEM_INFO();
            Kernel32.GetSystemInfo(ref src);
            var dst = new SystemMemoryInfo();
            dst.PageSize = src.dwPageSize;
            dst.Granularity = src.dwAllocationGranularity;
            dst.MinAppAddress = src.lpMinimumApplicationAddress;
            dst.MaxAppAddress= src.lpMaximumApplicationAddress;
            return dst;
        }
    }
}