//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly partial struct DbgHelp
    {
        public const string LibName = "Dbghelp.dll";

        [DllImport(LibName, SetLastError = true), Free]
        public static extern bool MiniDumpWriteDump(IntPtr hProcess, uint ProcessId, SafeFileHandle hFile, MINIDUMP_TYPE DumpType, IntPtr ExceptionParam, IntPtr UserStreamParam, IntPtr CallbackParam);

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/win32/api/minidumpapiset/nf-minidumpapiset-minidumpreaddumpstream
        /// </summary>
        /// <param name="mapped">A pointer to the base of the mapped minidump file. The file should have been mapped into memory using the MapViewOfFile function.</param>
        /// <param name="streamNumber">The type of data to be read from the minidump file. This member can be one of the values in the MINIDUMP_STREAM_TYPE enumeration.</param>
        /// <param name="pDirectory">A pointer to a MINIDUMP_DIRECTORY structure</param>
        /// <param name="pStream">A pointer to the beginning of the minidump stream. The format of this stream depends on the value of StreamNumber. For more information, see MINIDUMP_STREAM_TYPE.</param>
        /// <param name="pStreamSize">The size of the stream pointed to by StreamPointer, in bytes</param>
        /// <returns></returns>
        [DllImport(LibName, SetLastError = true), Free]
        public static unsafe extern bool MiniDumpReadDumpStream(IntPtr mapped, uint streamNumber, MINIDUMP_DIRECTORY* pDirectory, void* pStream, uint* pStreamSize);
    }

    // [Flags]
    // public enum MINIDUMP_TYPE : uint
    // {
    //     MiniDumpNormal                         = 0,

    //     MiniDumpWithDataSegs                   = 1 << 0,

    //     MiniDumpWithFullMemory                 = 1 << 1,

    //     MiniDumpWithHandleData                 = 1 << 2,

    //     MiniDumpFilterMemory                   = 1 << 3,

    //     MiniDumpScanMemory                     = 1 << 4,

    //     MiniDumpWithUnloadedModules            = 1 << 5,

    //     MiniDumpWithIndirectlyReferencedMemory = 1 << 6,

    //     MiniDumpFilterModulePaths              = 1 << 7,

    //     MiniDumpWithProcessThreadData          = 1 << 8,

    //     MiniDumpWithPrivateReadWriteMemory     = 1 << 9,

    //     MiniDumpWithoutOptionalData            = 1 << 10,

    //     MiniDumpWithFullMemoryInfo             = 1 << 11,

    //     MiniDumpWithThreadInfo                 = 1 << 12,

    //     MiniDumpWithCodeSegs                   = 1 << 13,

    //     MiniDumpWithoutAuxiliaryState          = 1 << 14,

    //     MiniDumpWithFullAuxiliaryState         = 1 << 15,

    //     MiniDumpWithPrivateWriteCopyMemory     = 1 << 16,

    //     MiniDumpIgnoreInaccessibleMemory       = 1 << 17,

    //     MiniDumpWithTokenInformation           = 1 << 18,

    //     MiniDumpWithModuleHeaders              = 1 << 19,

    //     MiniDumpFilterTriage                   = 1 << 20,

    //     MiniDumpWithAvxXStateContext           = 1 << 21,

    //     MiniDumpWithIptTrace                   = 1 << 22,

    //     MiniDumpValidTypeFlags                 = (-1) ^ ((~1) << 22)
    // }
}