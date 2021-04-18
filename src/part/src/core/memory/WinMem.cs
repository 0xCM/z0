//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Windows;

    using static Part;
    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost]
    public readonly unsafe struct WinMem
    {
        const string Kernel = "kernel32.dll";

        [DllImport(Kernel, SetLastError = true), Free]
        static extern int VirtualQueryEx(IntPtr process, IntPtr address, out BasicMemoryInfo lpBuffer, uint dwLength);

        [DllImport(Kernel, SetLastError = true), Free]
        static extern bool VirtualProtectEx(IntPtr process, IntPtr address, UIntPtr size, PageProtection protect, out PageProtection prior);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern bool VirtualProtect(IntPtr address, UIntPtr size, PageProtection protect, out PageProtection prior);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern UIntPtr VirtualAlloc(UIntPtr address, UIntPtr size, MemAllocType type, PageProtection protect);

        [DllImport(Kernel, SetLastError = true), Free]
        static unsafe extern bool VirtualFree(void* pAddress, UIntPtr sizeToFree, MemFreeType type);
   }
}