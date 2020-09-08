//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Buffers;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Image;

    public unsafe readonly struct WindowsFunctions
    {
        public bool IsEqualFileVersion(FS.FilePath file, DllVersion version)
        {
            if (!GetFileVersion(file.Name, out int major, out int minor, out int revision, out int patch))
                return false;

            return major == version.Major && minor == version.Minor && revision == version.Revision && patch == version.Patch;
        }

        public static bool IsProcessRunning(int processId)
        {
            IntPtr handle = Windows.Kernel32.OpenProcess(WindowsNativeMethods.PROCESS_QUERY_INFORMATION, false, processId);
            if (handle != IntPtr.Zero)
            {
                Windows.Kernel32.CloseHandle(handle);
                return true;
            }

            int minimumLength = 256;
            int[] processIds = ArrayPool<int>.Shared.Rent(minimumLength);
            try
            {
                int size;
                for (;;)
                {
                    Windows.PsApi.EnumProcesses(processIds, processIds.Length * sizeof(int), out size);
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
            return Windows.Kernel32.FreeLibrary(module);
        }

        public bool GetFileVersion(string dll, out int major, out int minor, out int revision, out int patch)
        {
            major = minor = revision = patch = 0;

            int len = WindowsNativeMethods.GetFileVersionInfoSize(dll, out int handle);
            if (len <= 0)
                return false;

            byte[] buffer = ArrayPool<byte>.Shared.Rent(len);
            try
            {
                fixed (byte* data = buffer)
                {
                    if (!WindowsNativeMethods.GetFileVersionInfo(dll, handle, len, data))
                        return false;

                    if (!WindowsNativeMethods.VerQueryValue(data, "\\", out IntPtr ptr, out len))
                        return false;

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

        public IntPtr GetProcAddress(IntPtr module, string method)
        {
            return Windows.Kernel32.GetProcAddress(module, method);
        }

        public IntPtr LoadLibrary(string lpFileName)
        {
            return Windows.Kernel32.LoadLibrary(lpFileName);
        }

        public bool TryGetWow64(IntPtr proc, out bool result)
        {
            if (Environment.OSVersion.Version.Major > 5 ||
                Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1)
                return Windows.Kernel32.IsWow64Process(proc, out result);

            result = false;
            return false;
        }
    }
}