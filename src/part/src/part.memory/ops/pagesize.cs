//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Windows;

    public unsafe readonly struct StackExtents
    {
        public byte* BaseAddress {get;}

        public ulong Size {get;}

        public StackExtents(byte* @base, ulong size)
        {
            BaseAddress = @base;
            Size = size;
        }
    }

    partial struct memory
    {
        [Op]
        public static ulong pagesize()
        {
            var sysInfo = new SYSTEM_INFO();
            Kernel32.GetSystemInfo(ref sysInfo);
            return sysInfo.dwPageSize;
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