//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public readonly unsafe struct WindowsNativeMethods
    {
        private const string Kernel32LibraryName = "kernel32.dll";

        private const string VersionLibraryName = "version.dll";

        public const int PROCESS_QUERY_INFORMATION = 0x0400;

        [DllImport(Kernel32LibraryName, SetLastError = true)]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport(Kernel32LibraryName, SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("psapi.dll", SetLastError = true)]
        public static extern unsafe bool EnumProcesses(int[] lpidProcess, int cb, out int lpcbNeeded);

        [DllImport(Kernel32LibraryName)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport(Kernel32LibraryName, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "LoadLibraryW")]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport(VersionLibraryName, CharSet = CharSet.Unicode, EntryPoint = "GetFileVersionInfoW")]
        public static extern bool GetFileVersionInfo(string sFileName, int handle, int size, byte* infoBuffer);

        [DllImport(VersionLibraryName, CharSet = CharSet.Unicode, EntryPoint = "GetFileVersionInfoSizeW")]
        public static extern int GetFileVersionInfoSize(string sFileName, out int handle);

        [DllImport(VersionLibraryName, CharSet = CharSet.Unicode, EntryPoint = "VerQueryValueW")]
        public static extern bool VerQueryValue(byte* pBlock, string pSubBlock, out IntPtr val, out int len);

        [DllImport(Kernel32LibraryName)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
    }
}