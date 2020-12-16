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

    public readonly partial struct Kernel32
    {
        public const string LibName = "kernel32.dll";

        /// <summary>
        /// Get the OS ID of the current thread
        /// </summary>
        [DllImport(LibName), Free]
        public static extern uint GetCurrentThreadId();

        /// <summary>
        /// Gets the handle of the current thread
        /// </summary>
        [DllImport(LibName), Free]
        public static extern IntPtr GetCurrentThread();

        [Fp(StdCall), Free]
        public delegate int DllMainDelegate(IntPtr instance, int reason, IntPtr reserved);

        [Fp(StdCall), Free]
        public delegate IntPtr GetProcAddressDelegate(IntPtr module, string name);

        [DllImport(LibName), Free]
        public static extern bool GetProcessWorkingSetSizeEx(IntPtr hProcess, out IntPtr lpMinimumWorkingSetSize, out IntPtr lpMaximumWorkingSetSize, out uint flags);

        [DllImport(LibName), Free]
        internal static extern bool ProcessIdToSessionId(uint dwProcessId, out uint pSessionId);

        [DllImport(LibName), Free]
        public static extern int GetProcessId(IntPtr nativeHandle);

        [DllImport(LibName), Free]
        public static unsafe extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte* lpBuffer, IntPtr dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport(LibName, SetLastError = true, EntryPoint = "K32EnumProcesses"), Free]
        public static extern unsafe bool EnumProcesses(int[] lpidProcess, int cb, out int lpcbNeeded);

        [DllImport(LibName), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport(LibName, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "LoadLibraryW"), Free]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport(LibName), Free]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport(LibName, SetLastError = true), Free]
        static extern UIntPtr VirtualAlloc(UIntPtr lpAddress, UIntPtr allocSize, [MarshalAs(UnmanagedType.U4)] VirtualAllocType allocationType, [MarshalAs(UnmanagedType.U4)] VirtualAllocProtection protection);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static unsafe extern bool VirtualFree(void* lpAddress, UIntPtr sizeToFree, [MarshalAs(UnmanagedType.U4)] VirtualFreeType freeType);

        [DllImport(LibName, ExactSpelling = true), Free]
        public static extern unsafe void* VirtualAlloc(void* lpAddress, UIntPtr dwSize, int flAllocationType, int flProtect);

        [DllImport(LibName, SetLastError = true, ExactSpelling = true), Free]
        public static extern unsafe UIntPtr VirtualQuery(void* lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);

        [DllImport(LibName), Free]
        public static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, uint flags, out uint oldFlags);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern IntPtr GetProcessHeap();

        [DllImport(LibName), Free]
        public static extern int QueryPerformanceCounter(ref long count);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocateUserPhysicalPages(IntPtr processHandle, ref UIntPtr numberOfPages, UIntPtr pageArray);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapUserPhysicalPages(UIntPtr virtualAddress, UIntPtr numberOfPages, UIntPtr pageArray);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeUserPhysicalPages(IntPtr processHandle, ref UIntPtr numberOfPages, UIntPtr pageArray);

        [DllImport(LibName, CharSet = CharSet.Auto, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern bool ReadFile(IntPtr hFile, UIntPtr lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

        [DllImport(LibName), Free]
        public static extern UIntPtr HeapAlloc(IntPtr heapHandle, [MarshalAs(UnmanagedType.U4)] HeapFlags heapFlags, UIntPtr bytesRequested);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern UIntPtr HeapSize(IntPtr heap, uint flags, UIntPtr lpMem);

        /// <summary>
        /// Retrieves the number of performance counter counts per second.
        /// </summary>
        /// <remarks>This is determined by the OS at boot time and is invariant until the next reboot</remarks>
        [DllImport(LibName), Free]
        public static extern int QueryPerformanceFrequency(ref long frequency);

        /// <summary>
        /// Retrieves the cyle time for a specified thread
        /// </summary>
        /// <param name="hThread">The handle to the thread</param>
        /// <param name="cycles">The number of cpu clock cycles used by the thread</param>
        [DllImport(LibName), Free]
        public static extern bool QueryThreadCycleTime(IntPtr hThread, ref ulong cycles);

        /// <summary>
        /// Retrieves the sum of the cycle time of all threads of the specified process.
        /// </summary>
        /// <param name="hProc">The handle to the process</param>
        /// <param name="cycles">The number of cpu clock cycles used by the threads of the process</param>
        [DllImport(LibName), Free]
        public static extern bool QueryProcessCycleTime(IntPtr hProc, ref ulong cycles);

        [DllImport(LibName), Free]
        public static extern void QueryInterruptTime(ref ulong time);

        [DllImport(LibName), Free]
        public static extern void QueryInterruptTimePrecise(ref ulong time);

        public static UIntPtr VirtualAlloc(uint allocSize, VirtualAllocType type, VirtualAllocProtection protection)
            => VirtualAlloc(lpAddress: UIntPtr.Zero, new UIntPtr(allocSize), type, protection);

        public static UIntPtr HeapAlloc(uint bytesRequested)
            => Kernel32.HeapAlloc(Kernel32.GetProcessHeap(), HeapFlags.None, new UIntPtr(bytesRequested));

        public static bool HeapFree(UIntPtr memory)
            => Kernel32.HeapFree(GetProcessHeap(), HeapFlags.None, memory);

        public static uint HeapSize(UIntPtr heapAddress)
        {
            UIntPtr heapSize = HeapSize(GetProcessHeap(), 0, heapAddress);
            return heapSize.ToUInt32();
        }

        public static IntPtr CreateFile(string fileName, FileMode mode)
            => CreateFile(fileName, mode, (mode == FileMode.Append ? FileAccess.Write : FileAccess.ReadWrite));

        public static IntPtr CreateFile(string fileName, FileMode mode, FileAccess access)
            => CreateFile(fileName, mode, access, FileShare.Read);

        public static IntPtr CreateFile(string fileName, FileMode mode, FileAccess access, FileShare share)
            => CreateFile(fileName, access, share, securityAttributes: IntPtr.Zero, mode, FileAttributes.Normal, templateFile: IntPtr.Zero);

        public static bool ReadFile(IntPtr hFile, IntPtr buffer, uint numberOfBytesToRead, out uint numberOfBytesRead)
            => ReadFile(hFile, buffer, numberOfBytesToRead, out numberOfBytesRead, lpOverlapped: IntPtr.Zero);

        public static bool ReadFile(IntPtr hFile, UIntPtr buffer, uint numberOfBytesToRead, out uint numberOfBytesRead)
            => ReadFile(hFile, buffer, numberOfBytesToRead, out numberOfBytesRead, lpOverlapped: IntPtr.Zero);

        public static bool SetFilePointerEx(IntPtr file, long distanceToMove, SeekOrigin seekOrigin)
            => SetFilePointerEx(file, distanceToMove, lpNewFilePointer: IntPtr.Zero, seekOrigin);

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

        [DllImport(LibName, SetLastError = true), Free]
        static extern bool ReadFile(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

        [DllImport(LibName, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool HeapFree(IntPtr heapHandle, [MarshalAs(UnmanagedType.U4)] HeapFlags heapFlags, UIntPtr lpMem);

        [DllImport(LibName, CharSet = CharSet.Auto, SetLastError = true), Free]
        static extern IntPtr CreateFile([MarshalAs(UnmanagedType.LPTStr)] string filename,
                                                [MarshalAs(UnmanagedType.U4)] FileAccess access,
                                                [MarshalAs(UnmanagedType.U4)] FileShare share,
                                                IntPtr securityAttributes,
                                                [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
                                                [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
                                                IntPtr templateFile);

        [DllImport(LibName), Free]
        static extern bool SetFilePointerEx(IntPtr hFile, long liDistanceToMove, IntPtr lpNewFilePointer, [MarshalAs(UnmanagedType.U4)] SeekOrigin dwMoveMethod);

    }
}