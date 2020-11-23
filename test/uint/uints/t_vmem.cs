//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;
    using System.Threading;
    using static Konst;
    using static z;

        public enum MemoryPageProtection : uint
        {
            Unspecified = 0,

            /// <summary>
            /// Disables all access to the committed region of pages. An attempt to read from, write to, or execute the committed region results in an access violation.
            /// </summary>
            NoAccess = 0x01,

            /// <summary>
            /// Enables read-only access to the committed region of pages
            /// </summary>
            ReadOnly = 0x02,

            /// <summary>
            /// Enables execute access to the committed region of pages. An attempt to write to the committed region results in an access violation. This flag is not supported by the CreateFileMapping function.
            /// </summary>
            Execute = 0x10,

            /// <summary>
            /// Enables execute or read-only access to the committed region of pages. An attempt to write to the committed region results in an access violation.
            /// </summary>
            ExecuteRead = 0x20,

            /// <summary>
            /// Enables execute, read-only, or read/write access to the committed region of pages.
            /// </summary>
            ReadWrite = 0x04,

            /// <summary>
            /// Pages in the region become guard pages. Any attempt to access a guard page causes the system to raise a STATUS_GUARD_PAGE_VIOLATION exception and turn off the guard page status. Guard pages thus act as a one-time access alarm.
            /// </summary>
            Guard = 0x100,

            /// <summary>
            /// Sets all pages to be non-cachable.
            /// </summary>
            NoCache = 0x200,

            WriteCombine = 400,

            ExecuteReadWrite = 0x40,

            /// <summary>
            /// Enables execute, read-only, or copy-on-write access to a mapped view of a file mapping object.
            /// An attempt to write to a committed copy-on-write page results in a private copy of the page being
            /// made for the process. The private page is marked as PAGE_EXECUTE_READWRITE, and the change is
            /// written to the new page. This flag is not supported by the VirtualAlloc or VirtualAllocEx functions
            /// </summary>
            ExecuteWriteCopy = 0x80,

            TargetsInvalid = 0x40000000,

            TargetsNoUpdate = 0x40000000,
        }


    public struct MemInfo
    {
        public MemoryAddress BaseAddress;

        public MemoryAddress AllocationBase;

        public ByteSize RegionSize;

        public ByteSize StackSize;

        public MemoryPageProtection Protection;
    }

    public struct SysInfo
    {

    }

    public unsafe class WinMem
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESSOR_INFO
        {
            internal ushort wProcessorArchitecture;

            internal ushort wReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            internal PROCESSOR_INFO uProcessorInfo;

            /// <summary>
            /// The page size and the granularity of page protection and commitment
            /// </summary>
            public uint dwPageSize;

            /// <summary>
            /// A pointer to the lowest memory address accessible to applications and dynamic-link libraries (DLLs).
            /// </summary>
            public IntPtr lpMinimumApplicationAddress;

            /// <summary>
            /// A pointer to the highest memory address accessible to applications and DLLs.
            /// </summary>
            public IntPtr lpMaximumApplicationAddress;

            /// <summary>
            /// A mask representing the set of processors configured into the system. Bit 0 is processor 0; bit 31 is processor 31.
            /// </summary>
            public IntPtr dwActiveProcessorMask;

            /// <summary>
            /// The number of logical processors in the current group
            /// </summary>
            public uint dwNumberOfProcessors;

            [Obsolete]
            public uint dwProcessorType;

            /// <summary>
            /// The granularity for the starting address at which virtual memory can be allocated.
            /// </summary>
            public uint dwAllocationGranularity;

            public ushort dwProcessorLevel;

            public ushort dwProcessorRevision;
        }

        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32")]
        static extern IntPtr VirtualQuery(void* address, ref MEMORY_BASIC_INFORMATION buffer, IntPtr length);

        public struct MEMORY_BASIC_INFORMATION
        {
            /// <summary>
            /// A pointer to the base address of the region of pages.
            /// </summary>
            public byte* BaseAddress;

            /// <summary>
            /// A pointer to the base address of a range of pages allocated by the VirtualAlloc function.
            /// The page pointed to by the BaseAddress member is contained within this allocation range
            /// </summary>
            public byte* AllocationBase;

            public MemoryPageProtection AllocationProtect;

            /// <summary>
            /// The size of the region beginning at the base address in which all pages have identical attributes, in bytes.
            /// </summary>
            public IntPtr RegionSize;

            public MemState State;

            public uint Protect;

            public uint Type;
        }

        [Flags]
        public enum MemState
        {
            MEM_COMMIT = 0x1000,
            MEM_RESERVE = 0x2000,
            MEM_FREE = 0x10000,
        }

        public const int PAGE_GUARD = 0x100;


        public static SYSTEM_INFO sysinfo()
        {
            var dst = new SYSTEM_INFO();
            GetSystemInfo(ref dst);
            return dst;
        }

        public static MemInfo meminfo()
        {
            var src = new MEMORY_BASIC_INFORMATION();
            var dst = new MemInfo();
            VirtualQuery(&src, ref src, new IntPtr(sizeof(MEMORY_BASIC_INFORMATION)));

            dst.AllocationBase = src.AllocationBase;
            dst.BaseAddress = src.BaseAddress;
            dst.RegionSize = src.RegionSize;
            dst.StackSize = (ulong)(dst.BaseAddress - dst.AllocationBase) + dst.RegionSize;
            dst.Protection = (MemoryPageProtection)src.AllocationProtect;
            return dst;
        }

    }


    public class t_vmem : t_uint<t_vmem>
    {

    }


}