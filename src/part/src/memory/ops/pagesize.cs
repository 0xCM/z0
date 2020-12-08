//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Windows;

    using static Part;

    public unsafe readonly struct StackExtents
    {
        public byte* BaseAddress {get;}

        public ByteSize Size {get;}

        public StackExtents(byte* @base, ByteSize size)
        {
            BaseAddress = @base;
            Size = size;
        }
    }

    partial struct memory
    {

        [Op]
        public static ByteSize pagesize()
        {
            var sysInfo = new SYSTEM_INFO();
            Kernel32.GetSystemInfo(ref sysInfo);
            return sysInfo.dwPageSize;
        }

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