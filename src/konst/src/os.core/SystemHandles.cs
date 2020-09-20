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
    using System.Runtime.ConstrainedExecution;
    using System.Security;


    using static Konst;

    public readonly struct SystemHandles
    {
        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [DllImport(WinLibs.Kernel32, SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        public readonly struct ProcessHandle : ISystemHandle<ProcessHandle>
        {
            public MemoryAddress Address {get;}

            public bool IsOwner {get;}

            [MethodImpl(Inline)]
            public ProcessHandle(IntPtr handle, bool own = true)
            {
                Address = handle;
                IsOwner  = own;
            }
        }

        public readonly struct DllHandle : ISystemHandle<DllHandle>
        {
            public MemoryAddress Address {get;}

            public bool IsOwner {get;}

            [MethodImpl(Inline)]
            public DllHandle(IntPtr handle, bool own = true)
            {
                Address = handle;
                IsOwner  = own;
            }
        }
    }
}