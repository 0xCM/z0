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
        public static unsafe int ReadProcessMemory(IntPtr process, ulong address, Span<byte> dst)
        {
            try
            {
                fixed (byte* ptr = dst)
                {
                    int res = ReadProcessMemory(process, new IntPtr((nint)address), ptr, new IntPtr(dst.Length), out IntPtr read);
                    return (int)read;
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

        [DllImport(LibName), Free]
        static unsafe extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte* lpBuffer, IntPtr dwSize, out IntPtr lpNumberOfBytesRead);
    }
}