//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    public unsafe readonly struct WindowsFunctions
    {
        public bool IsEqualFileVersion(string file, VersionInfo version)
        {
            if (!GetFileVersion(file, out int major, out int minor, out int revision, out int patch))
                return false;

            return major == version.Major && minor == version.Minor && revision == version.Revision && patch == version.Patch;
        }

        public static bool IsProcessRunning(int processId)
        {
            IntPtr handle = NativeMethods.OpenProcess(NativeMethods.PROCESS_QUERY_INFORMATION, false, processId);
            if (handle != IntPtr.Zero)
            {
                NativeMethods.CloseHandle(handle);
                return true;
            }

            int minimumLength = 256;
            int[] processIds = ArrayPool<int>.Shared.Rent(minimumLength);
            try
            {
                int size;
                for (; ; )
                {
                    NativeMethods.EnumProcesses(processIds, processIds.Length * sizeof(int), out size);
                    if (size == processIds.Length * sizeof(int))
                    {
                        ArrayPool<int>.Shared.Return(processIds);
                        minimumLength *= 2;
                        processIds = ArrayPool<int>.Shared.Rent(minimumLength);
                        continue;
                    }

                    break;
                }

                return Array.IndexOf(processIds, processId, 0, size / sizeof(int)) >= 0;
            }
            finally
            {
                ArrayPool<int>.Shared.Return(processIds);
            }
        }

        public bool FreeLibrary(IntPtr module)
        {
            return NativeMethods.FreeLibrary(module);
        }

        public bool GetFileVersion(string dll, out int major, out int minor, out int revision, out int patch)
        {
            major = minor = revision = patch = 0;

            int len = NativeMethods.GetFileVersionInfoSize(dll, out int handle);
            if (len <= 0)
                return false;

            byte[] buffer = ArrayPool<byte>.Shared.Rent(len);
            try
            {
                fixed (byte* data = buffer)
                {
                    if (!NativeMethods.GetFileVersionInfo(dll, handle, len, data))
                        return false;

                    if (!NativeMethods.VerQueryValue(data, "\\", out IntPtr ptr, out len))
                        return false;

                    DebugOnly.Assert(unchecked((int)ptr.ToInt64()) % sizeof(ushort) == 0);

                    minor = Unsafe.Read<ushort>((ptr + 8).ToPointer());
                    major = Unsafe.Read<ushort>((ptr + 10).ToPointer());
                    patch = Unsafe.Read<ushort>((ptr + 12).ToPointer());
                    revision = Unsafe.Read<ushort>((ptr + 14).ToPointer());

                    return true;
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }

        public static IntPtr GetProcAddress(IntPtr module, string method)
        {
            return NativeMethods.GetProcAddress(module, method);
        }

        public static IntPtr LoadLibrary(string lpFileName)
        {
            return NativeMethods.LoadLibrary(lpFileName);
        }

        public static bool TryGetWow64(IntPtr proc, out bool result)
        {
            if (Environment.OSVersion.Version.Major > 5 ||
                Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1)
            {
                return NativeMethods.IsWow64Process(proc, out result);
            }

            result = false;
            return false;
        }
        
        readonly struct NativeMethods
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

            [DllImport(Kernel32LibraryName)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsWow64Process(IntPtr hProcess, out bool isWow64);

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
}