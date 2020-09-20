//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Security;

    using static Konst;
    using static z;
    using static Windows.Kernel32;
    using static SystemHandles;

    [ApiHost]
    public readonly struct Handles
    {
        [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurity]
        static extern IntPtr LoadLibrary(string libFilename);

        /// <summary>
        /// Dispenses a handle to an identified process
        /// </summary>
        /// <param name="pid">The process identifier</param>
        [MethodImpl(Inline), Op]
        public static SystemHandle<ProcessHandle> process(int pid)
            => new ProcessHandle(Windows.Kernel32.OpenProcess(ProcessAccess.PROCESS_VM_READ | ProcessAccess.PROCESS_QUERY_INFORMATION, false, pid));

        /// <summary>
        /// Dispenses a handle to the current process
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SystemHandle<ProcessHandle> process()
            => process(Process.GetCurrentProcess().Id);

        [MethodImpl(Inline), Op]
        public static SystemHandle<DllHandle> dll(FS.FileName src)
            => new DllHandle(LoadLibrary(src.Name));

        [MethodImpl(Inline), Op]
        public static SystemHandle<DllHandle> dll(FS.FilePath src)
            => new DllHandle(LoadLibrary(src.Name));

        public static Span<int> processes(uint max = 512)
        {
            var dst = alloc<int>((int)max);
            var size = dst.Length * sizeof(int);
            Windows.ProcessApi.EnumProcesses(dst, size, out var _);
            return dst;
        }
    }
}