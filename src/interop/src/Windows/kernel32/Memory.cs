// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;
    using System.IO;
    using System.Diagnostics;

    using static System.Runtime.InteropServices.CallingConvention;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using Fp = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

    partial struct Kernel32
    {
        public static unsafe ulong ReadProcessMemory(IntPtr process, ulong address, Span<byte> dst)
        {
            try
            {
                fixed(byte* ptr = dst)
                {
                    int res = ReadProcessMemory(process, &address, ptr, new UIntPtr((uint)dst.Length), out UIntPtr read);
                    return (ulong)read;
                }
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        public static bool AllocateUserPhysicalPages(ref uint numberOfPages, UIntPtr pageArray)
        {
            var numberOfPagesRequested = new UIntPtr(numberOfPages);
            var res = Kernel32.AllocateUserPhysicalPages(Process.GetCurrentProcess().Handle, ref numberOfPagesRequested, pageArray);
            numberOfPages = numberOfPagesRequested.ToUInt32();
            return res;
        }

        public static bool MapUserPhysicalPages(UIntPtr virtualAddress, uint numberOfPages, UIntPtr pageArray)
        {
            UIntPtr numberOfPagesToMap = new UIntPtr(numberOfPages);
            return Kernel32.MapUserPhysicalPages(virtualAddress, numberOfPagesToMap, pageArray);
        }

        public static bool FreeUserPhysicalPages(ref uint numberfOfPages, UIntPtr pageArray)
        {
            UIntPtr numberOfPagesToFree = new UIntPtr(numberfOfPages);
            bool res = Kernel32.FreeUserPhysicalPages(Process.GetCurrentProcess().Handle, ref numberOfPagesToFree, pageArray);
            numberfOfPages = numberOfPagesToFree.ToUInt32();
            return res;
        }

        public static UIntPtr HeapAlloc(uint bytesRequested)
            => Kernel32.HeapAlloc(Kernel32.GetProcessHeap(), HeapFlags.None, new UIntPtr(bytesRequested));

        public static bool HeapFree(UIntPtr memory)
            => HeapFree(GetProcessHeap(), HeapFlags.None, memory);

        public static uint HeapSize(UIntPtr heapAddress)
        {
            UIntPtr heapSize = HeapSize(GetProcessHeap(), 0, heapAddress);
            return heapSize.ToUInt32();
        }

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool HeapFree(IntPtr heapHandle, [MarshalAs(UnmanagedType.U4)] HeapFlags heapFlags, UIntPtr lpMem);

        [DllImport(LibName), Free]
        static extern UIntPtr HeapAlloc(IntPtr heapHandle, [MarshalAs(UnmanagedType.U4)] HeapFlags heapFlags, UIntPtr bytesRequested);

        [DllImport(LibName, SetLastError = true), Free]
        static extern UIntPtr HeapSize(IntPtr heap, uint flags, UIntPtr lpMem);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocateUserPhysicalPages(IntPtr processHandle, ref UIntPtr numberOfPages, UIntPtr pageArray);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool MapUserPhysicalPages(UIntPtr virtualAddress, UIntPtr numberOfPages, UIntPtr pageArray);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeUserPhysicalPages(IntPtr processHandle, ref UIntPtr numberOfPages, UIntPtr pageArray);

        /// <summary>
        /// Reads data from an area of memory in a specified process. The entire area to be read must be accessible or the operation fails.
        /// </summary>
        /// <param name="hProcess">A handle to the process with memory that is being read. The handle must have <see cref="ProcessAccess.PROCESS_VM_READ"/> access to the process.</param>
        /// <param name="lpBaseAddress">A pointer to the base address in the specified process from which to read. Before any data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for read access, and if it is not accessible the function fails.</param>
        /// <param name="lpBuffer">A pointer to a buffer that receives the contents from the address space of the specified process.</param>
        /// <param name="nSize">The number of bytes to be read from the specified process.</param>
        /// <param name="lpNumberOfBytesRead">A variable that receives the number of bytes transferred into the specified buffer.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is 0 (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// The function fails if the requested read operation crosses into an area of the process that is inaccessible.
        /// </returns>
        [DllImport(LibName), Free]
        static unsafe extern int ReadProcessMemory(IntPtr hProcess, void* lpBaseAddress, byte* lpBuffer, UIntPtr dwSize, out UIntPtr lpNumberOfBytesRead);

        /// <summary>
        /// Writes data to an area of memory in a specified process. The entire area to be written to must be accessible or the operation fails.
        /// </summary>
        /// <param name="hProcess">A handle to the process memory to be modified. The handle must have <see cref="ProcessAccess.PROCESS_VM_WRITE"/> and <see cref="ProcessAccess.PROCESS_VM_OPERATION"/> access to the process.</param>
        /// <param name="lpBaseAddress">A pointer to the base address in the specified process to which data is written. Before data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for write access, and if it is not accessible, the function fails.</param>
        /// <param name="lpBuffer">A pointer to the buffer that contains data to be written in the address space of the specified process.</param>
        /// <param name="nSize">The number of bytes to be written to the specified process.</param>
        /// <param name="lpNumberOfBytesWritten">A variable that receives the number of bytes transferred into the specified process.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is 0 (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>. The function fails if the requested write operation crosses into an area of the process that is inaccessible.
        /// </returns>
        [DllImport(nameof(Kernel32), SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool WriteProcessMemory(IntPtr hProcess, void* lpBaseAddress, byte* lpBuffer, UIntPtr nSize, out UIntPtr lpNumberOfBytesWritten);

    }
}