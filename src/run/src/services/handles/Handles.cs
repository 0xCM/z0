//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;
    using static Windows.Kernel32;
    using static HandleTypes;

    [ApiHost]
    public readonly struct Handles
    {
        /// <summary>
        /// Dispenses a handle to an identified process
        /// </summary>
        /// <param name="pid">The process identifier</param>
        [MethodImpl(Inline), Op]
        public static Handle<ProcessHandle> process(int pid)
            => new ProcessHandle(Windows.Kernel32.OpenProcess(ProcessAccess.PROCESS_VM_READ | ProcessAccess.PROCESS_QUERY_INFORMATION, false, pid));

        /// <summary>
        /// Dispenses a handle to the current process
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Handle<ProcessHandle> process()
            => process(Process.GetCurrentProcess().Id);

        [MethodImpl(Inline), Op]
        public static Handle<DllHandle> dll(FS.FileName src)
            => new DllHandle(Windows.Kernel32.LoadLibrary(src.Name));

        [MethodImpl(Inline), Op]
        public static Handle<DllHandle> dll(FS.FilePath src)
            => new DllHandle(Windows.Kernel32.LoadLibrary(src.Name));

        public static Span<int> processes(uint max = 512)
        {
            var dst = z.alloc<int>((int)max);
            var size = dst.Length * sizeof(int);
            Windows.ProcessApi.EnumProcesses(dst, size, out var _);
            return dst;
        }
    }

    public readonly partial struct HandleTypes
    {


    }
}