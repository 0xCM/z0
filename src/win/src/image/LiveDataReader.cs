//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    using Z0.Dac;
    using Z0.MS;
        
    public class ProcessReaderException : Exception
    {
        public ProcessReaderException(string pattern, params object[] src)
            : base(text.format(pattern,src))
        {

        }        
    }

    static class ProcessDataReaderX
    {
        public static IntPtr AsIntPtr(this ulong address)
        {
            if (IntPtr.Size == 8)
                return new IntPtr((long)address);

            return new IntPtr((int)address);
        }        

        public static unsafe ulong AsPointer(this Span<byte> span)
        {
            return IntPtr.Size == 4
                ? Unsafe.As<byte, uint>(ref MemoryMarshal.GetReference(span))
                : Unsafe.As<byte, ulong>(ref MemoryMarshal.GetReference(span));
        }

        public static unsafe int AsInt32(this Span<byte> span)
            => Unsafe.As<byte, int>(ref MemoryMarshal.GetReference(span));

        public static unsafe uint AsUInt32(this Span<byte> span)
            => Unsafe.As<byte, uint>(ref MemoryMarshal.GetReference(span));

    }
    public unsafe class ProcessDataReader : IProcessDataReader
    {
        static WindowsFunctions WinFx => default;
        
        private bool _disposed = false;
        
        private readonly int _originalPid;
        
        private readonly IntPtr _snapshotHandle;
        
        private readonly IntPtr _cloneHandle;
        
        private readonly IntPtr _process;
        
        private readonly int _pid;

        private const int PROCESS_VM_READ = 0x10;
        
        private const int PROCESS_QUERY_INFORMATION = 0x0400;

        public ProcessDataReader(int processId, bool createSnapshot)
        {
            if (createSnapshot)
            {
                _originalPid = processId;

                // Throws
                Process process = Process.GetProcessById(processId);
                int hr = PssCaptureSnapshot(process.Handle, PSS_CAPTURE_FLAGS.PSS_CAPTURE_VA_CLONE, IntPtr.Size == 8 ? 0x0010001F : 0x0001003F, out _snapshotHandle);
                if (hr != 0)
                    throw new ProcessReaderException($"Could not create snapshot to process. Error {hr}.", ClrDiagnosticsExceptionKind.Unknown, hr);

                hr = PssQuerySnapshot(_snapshotHandle, PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_VA_CLONE_INFORMATION, out _cloneHandle, IntPtr.Size);
                if (hr != 0)
                    throw new ProcessReaderException($"Could not query the snapshot. Error {hr}.", ClrDiagnosticsExceptionKind.Unknown, hr);

                _pid = GetProcessId(_cloneHandle);
            }
            else
            {
                _pid = processId;
            }

            _process = NativeMethods.OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, false, _pid);

            if (_process == IntPtr.Zero)
            {
                if (!WindowsFunctions.IsProcessRunning(_pid))
                    throw new ArgumentException("The process is not running");

                int hr = Marshal.GetLastWin32Error();
                throw new ProcessReaderException($"Could not attach to process. Error {hr}.", ClrDiagnosticsExceptionKind.Unknown, hr);
            }

            using Process p = Process.GetCurrentProcess();
            if (WinFx.TryGetWow64(p.Handle, out bool wow64)
                && WinFx.TryGetWow64(_process, out bool targetWow64)
                && wow64 != targetWow64)
            {
                throw new ProcessReaderException("Dac architecture mismatch!", ClrDiagnosticsExceptionKind.DacError);
            }
        }

        private void Dispose(bool _)
        {
            if (!_disposed)
            {
                if (_originalPid != 0)
                {
                    int hr = PssFreeSnapshot(Process.GetCurrentProcess().Handle, _snapshotHandle);
                    if (hr != 0)
                        throw new ProcessReaderException($"Could not free the snapshot. Error {hr}.", ClrDiagnosticsExceptionKind.Unknown, hr);

                    try
                    {
                        Process.GetProcessById(_pid).Kill();
                    }
                    catch (Win32Exception)
                    {
                    }
                }

                if (_process != IntPtr.Zero)
                    WindowsNativeMethods.CloseHandle(_process);

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ProcessDataReader()
        {
            Dispose(false);
        }

        public uint ProcessId => (uint)_pid;

        public bool IsThreadSafe => true;

        public bool IsFullMemoryAvailable => true;

        public void FlushCachedData()
        {
        }

        public MS.Architecture Architecture => IntPtr.Size == 4 ? MS.Architecture.X86 : MS.Architecture.Amd64;

        public int PointerSize => IntPtr.Size;

        public IEnumerable<ModuleDescription> EnumerateModules()
        {
            List<ModuleDescription> result = new List<ModuleDescription>();

            EnumProcessModules(_process, null, 0, out uint needed);

            IntPtr[] modules = new IntPtr[needed / 4];
            uint size = (uint)modules.Length * sizeof(uint);

            if (!EnumProcessModules(_process, modules, size, out _))
                throw new ProcessReaderException("Unable to get process modules.", ClrDiagnosticsExceptionKind.DataRequestError);

            for (int i = 0; i < modules.Length; i++)
            {
                IntPtr ptr = modules[i];

                if (ptr == IntPtr.Zero)
                {
                    break;
                }

                StringBuilder sb = new StringBuilder(1024);
                uint res = GetModuleFileNameEx(_process, ptr, sb, sb.Capacity);

                ulong baseAddr = (ulong)ptr.ToInt64();
                GetFileProperties(baseAddr, out int filesize, out int timestamp);

                string fileName = sb.ToString();
                ModuleDescription module = new ModuleDescription(baseAddr, filesize, timestamp, fileName, default);
                result.Add(module);
            }

            return result;
        }

        public void GetVersionInfo(ulong addr, out VersionInfo version)
        {
            StringBuilder fileName = new StringBuilder(1024);
            uint res = GetModuleFileNameEx(_process, addr.AsIntPtr(), fileName, fileName.Capacity);

            if (WinFx.GetFileVersion(fileName.ToString(), out int major, out int minor, out int revision, out int patch))
                version = new VersionInfo(major, minor, revision, patch);
            else
                version = default;
        }

        public bool Read(ulong address, Span<byte> buffer, out int bytesRead)
        {
            try
            {
                fixed (byte* ptr = buffer)
                {
                    int res = ReadProcessMemory(_process, address.AsIntPtr(), ptr, new IntPtr(buffer.Length), out IntPtr read);
                    bytesRead = (int)read;
                    return res != 0;
                }
            }
            catch
            {
                bytesRead = 0;
                return false;
            }
        }

        public ulong ReadPointer(ulong address)
        {
            ReadPointer(address, out ulong value);
            return value;
        }

        public unsafe bool Read<T>(ulong address, out T value) where T : unmanaged
        {
            Span<byte> buffer = stackalloc byte[sizeof(T)];
            if (Read(address, buffer, out int size) && size == sizeof(T))
            {
                value = Unsafe.As<byte, T>(ref MemoryMarshal.GetReference(buffer));
                return true;
            }

            value = default;
            return false;
        }

        public T Read<T>(ulong address) where T : unmanaged
        {
            Read(address, out T value);
            return value;
        }

        public bool ReadPointer(ulong address, out ulong value)
        {
            Span<byte> buffer = stackalloc byte[IntPtr.Size];
            if (Read(address, buffer, out int size) && size == IntPtr.Size)
            {
                value =  buffer.AsPointer();
                return true;
            }

            value = 0;
            return false;
        }

        public IEnumerable<uint> EnumerateAllThreads()
        {
            using Process process = Process.GetProcessById(_pid);
            ProcessThreadCollection threads = process.Threads;
            for (int i = 0; i < threads.Count; i++)
                yield return (uint)threads[i].Id;
        }

        public unsafe bool QueryMemory(ulong address, out MemoryRegionInfo vq)
        {
            IntPtr ptr = address.AsIntPtr();

            int res = VirtualQueryEx(_process, ptr, out MEMORY_BASIC_INFORMATION mem, new IntPtr(sizeof(MEMORY_BASIC_INFORMATION)));
            if (res == 0)
            {
                vq = default;
                return false;
            }

            vq = new MemoryRegionInfo(mem.BaseAddress, mem.Size);
            return true;
        }

        public bool GetThreadContext(uint threadID, uint contextFlags, Span<byte> context)
        {
            using SafeWin32Handle thread = OpenThread(ThreadAccess.THREAD_ALL_ACCESS, true, threadID);
            if (thread.IsInvalid)
                return false;

            fixed (byte* ptr = context)
                return GetThreadContext(thread.DangerousGetHandle(), new IntPtr(ptr));
        }

        private void GetFileProperties(ulong moduleBase, out int filesize, out int timestamp)
        {
            filesize = 0;
            timestamp = 0;

            Span<byte> buffer = stackalloc byte[sizeof(uint)];

            if (Read(moduleBase + 0x3c, buffer, out int read) && read == buffer.Length)
            {
                uint sigOffset = buffer.AsUInt32();
                int sigLength = 4;

                if (Read(moduleBase + sigOffset, buffer, out read) && read == buffer.Length)
                {
                    uint header = buffer.AsUInt32();

                    if (header == 0x4550)
                    {
                        const int timeDataOffset = 4;
                        const int imageSizeOffset = 0x4c;
                        if (Read(moduleBase + sigOffset + (ulong)sigLength + timeDataOffset, buffer, out read) && read == buffer.Length)
                            timestamp = buffer.AsInt32();

                        if (Read(moduleBase + sigOffset + (ulong)sigLength + imageSizeOffset, buffer, out read) && read == buffer.Length)
                            filesize = buffer.AsInt32();
                    }
                }
            }
        }

        private const string Kernel32LibraryName = "kernel32.dll";

        [DllImport("psapi.dll", SetLastError = true)]
        public static extern bool EnumProcessModules(IntPtr hProcess, [Out] IntPtr[]? lphModule, uint cb, [MarshalAs(UnmanagedType.U4)] out uint lpcbNeeded);

        [DllImport("psapi.dll", CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "GetModuleFileNameExW")]
        [PreserveSig]
        public static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpFilename, [MarshalAs(UnmanagedType.U4)] int nSize);

        [DllImport(Kernel32LibraryName)]
        private static extern int ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte* lpBuffer,
            IntPtr dwSize,
            out IntPtr lpNumberOfBytesRead);

        [DllImport(Kernel32LibraryName, SetLastError = true)]
        internal static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, IntPtr dwLength);

        [DllImport(Kernel32LibraryName)]
        private static extern bool GetThreadContext(IntPtr hThread, IntPtr lpContext);

        [DllImport(Kernel32LibraryName, SetLastError = true)]
        private static extern SafeWin32Handle OpenThread(ThreadAccess dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwThreadId);

        [DllImport(Kernel32LibraryName)]
        private static extern int PssCaptureSnapshot(IntPtr ProcessHandle, PSS_CAPTURE_FLAGS CaptureFlags, int ThreadContextFlags, out IntPtr SnapshotHandle);

        [DllImport(Kernel32LibraryName)]
        private static extern int PssFreeSnapshot(IntPtr ProcessHandle, IntPtr SnapshotHandle);

        [DllImport(Kernel32LibraryName)]
        private static extern int PssQuerySnapshot(IntPtr SnapshotHandle, PSS_QUERY_INFORMATION_CLASS InformationClass, out IntPtr Buffer, int BufferLength);

        [DllImport(Kernel32LibraryName)]
        private static extern int GetProcessId(IntPtr hObject);
    }
}