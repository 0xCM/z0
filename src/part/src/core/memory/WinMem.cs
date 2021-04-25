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

    using static Root;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost]
    public readonly unsafe struct WinMem
    {
        const string Kernel = "kernel32.dll";

        /// <summary>
        /// Reserves, commits, or changes the state of a region of pages in the virtual address space of the calling process.
        /// Memory allocated by this function is automatically initialized to zero.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="type"></param>
        /// <param name="protect"></param>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-virtualalloc
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static MemoryAddress VirtualAlloc(ByteSize size, MemAllocType type, PageProtection protect)
            => VirtualAlloc(address: UIntPtr.Zero, size, type, protect);

        [MethodImpl(Inline), Op]
        public static unsafe bool VirtualFree(MemoryAddress address, ByteSize size, MemFreeType type)
            => VirtualFree(address.Pointer(), (UIntPtr)size, type);

        /// <summary>
        /// Retrieves information about a range of pages in the virtual address space of the calling process
        /// </summary>
        /// <param name="address">A pointer to the base address of the region of pages to be queried. This value is rounded down to the next page boundary.</param>
        /// <param name="dst">The query result</param>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-virtualquery
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static void VirtualQuery(MemoryAddress address, ref BasicMemoryInfo dst)
            => VirtualQuery((IntPtr)address, ref dst, (UIntPtr)memory.size<BasicMemoryInfo>());

        [DllImport(Kernel, SetLastError = true), Free]
        static extern UIntPtr VirtualQuery(IntPtr address, ref BasicMemoryInfo lpBuffer, UIntPtr dwLength);

        /// <summary>
        /// Retrieves information about a range of pages within the virtual address space of a specified proces.
        /// The return value is the actual number of bytes returned in the information buffer.
        /// </summary>
        /// <param name="process"></param>
        /// <param name="address"></param>
        /// <param name="info"></param>
        /// <param name="size"></param>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-virtualqueryex
        /// </remarks>
        [DllImport(Kernel, SetLastError = true), Free]
        public static extern UIntPtr VirtualQueryEx(IntPtr process, IntPtr address, out BasicMemoryInfo info, UIntPtr size);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern bool VirtualProtectEx(IntPtr process, IntPtr address, UIntPtr size, PageProtection protect, out PageProtection prior);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern bool VirtualProtect(IntPtr address, UIntPtr size, PageProtection protect, out PageProtection prior);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern UIntPtr VirtualAlloc(UIntPtr address, UIntPtr size, MemAllocType type, PageProtection protect);

        [DllImport(Kernel, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        static unsafe extern bool VirtualFree(void* address, UIntPtr size, [MarshalAs(UnmanagedType.U4)] MemFreeType type);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern bool GetProcessWorkingSetSizeEx(IntPtr hProcess, out IntPtr minSize, out IntPtr maxSize, out WorkingSetFlags flags);
   }
}