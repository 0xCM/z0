//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    public unsafe static class NativeMethods
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

        [DllImport(Kernel32LibraryName)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process(IntPtr hProcess, out bool isWow64);

        [DllImport(VersionLibraryName, CharSet = CharSet.Unicode, EntryPoint = "GetFileVersionInfoW")]
        public static extern bool GetFileVersionInfo(string sFileName, int handle, int size, byte* infoBuffer);

        [DllImport(VersionLibraryName, CharSet = CharSet.Unicode, EntryPoint = "GetFileVersionInfoSizeW")]
        public static extern int GetFileVersionInfoSize(string sFileName, out int handle);

        [DllImport(VersionLibraryName, CharSet = CharSet.Unicode, EntryPoint = "VerQueryValueW")]
        public static extern bool VerQueryValue(byte* pBlock, string pSubBlock, out IntPtr val, out int len);


    }

}