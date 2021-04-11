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

    partial struct memory
    {
        /// <summary>
        /// Returns a <see cref='StackExtents'/> populated with data obtained from the system
        /// </summary>
        [Op]
        public static unsafe StackExtents stack()
        {
            var info = new MEMORY_BASIC_INFORMATION();
            Kernel32.VirtualQuery(&info, ref info, new UIntPtr((uint)sizeof(MEMORY_BASIC_INFORMATION)));
            MemoryAddress @base = info.AllocationBase;
            var size = (ulong)(info.BaseAddress - info.AllocationBase) + info.RegionSize;
            return new StackExtents(@base,size);
        }
    }
}