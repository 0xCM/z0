//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Windows;

    using static Windows.Kernel32;

    unsafe partial struct Buffers
    {
        [Op, Closures(Closure)]
        public unsafe static T* valloc<T>(ulong size, MemAllocType type, PageProtection protection)
            where T : unmanaged
                => (T*)WinMem.VirtualAlloc(UIntPtr.Zero, (UIntPtr)size, type, protection);

        [Op, Closures(Closure)]
        public unsafe static bool vfree<T>(T* pSrc, ulong size, MemFreeType type)
            where T : unmanaged
                => VirtualFree((void*)pSrc, (UIntPtr)size, type);
    }
}