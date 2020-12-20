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
        [DllImport("Dbghelp.dll", SetLastError = true), Free]
        public static extern bool MiniDumpWriteDump(IntPtr hProcess, uint ProcessId, SafeFileHandle hFile, MINIDUMP_TYPE DumpType, IntPtr ExceptionParam, IntPtr UserStreamParam, IntPtr CallbackParam);
    }

    [Flags]
    public enum MINIDUMP_TYPE : uint
    {
        MiniDumpNormal                         = 0,

        MiniDumpWithDataSegs                   = 1 << 0,

        MiniDumpWithFullMemory                 = 1 << 1,

        MiniDumpWithHandleData                 = 1 << 2,

        MiniDumpFilterMemory                   = 1 << 3,

        MiniDumpScanMemory                     = 1 << 4,

        MiniDumpWithUnloadedModules            = 1 << 5,

        MiniDumpWithIndirectlyReferencedMemory = 1 << 6,

        MiniDumpFilterModulePaths              = 1 << 7,

        MiniDumpWithProcessThreadData          = 1 << 8,

        MiniDumpWithPrivateReadWriteMemory     = 1 << 9,

        MiniDumpWithoutOptionalData            = 1 << 10,

        MiniDumpWithFullMemoryInfo             = 1 << 11,

        MiniDumpWithThreadInfo                 = 1 << 12,

        MiniDumpWithCodeSegs                   = 1 << 13,

        MiniDumpWithoutAuxiliaryState          = 1 << 14,

        MiniDumpWithFullAuxiliaryState         = 1 << 15,

        MiniDumpWithPrivateWriteCopyMemory     = 1 << 16,

        MiniDumpIgnoreInaccessibleMemory       = 1 << 17,

        MiniDumpWithTokenInformation           = 1 << 18,

        MiniDumpWithModuleHeaders              = 1 << 19,

        MiniDumpFilterTriage                   = 1 << 20,

        MiniDumpWithAvxXStateContext           = 1 << 21,

        MiniDumpWithIptTrace                   = 1 << 22,

        MiniDumpValidTypeFlags                 = (-1) ^ ((~1) << 22)
    }
}