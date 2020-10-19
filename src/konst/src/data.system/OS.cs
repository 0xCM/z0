//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using static Konst;
    using static z;

    public readonly partial struct OS
    {
        [DllImport(Kernel32), SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport(Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "LoadLibraryW"), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport(Kernel32), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        public readonly struct Delegates
        {
            [UnmanagedFunctionPointer(StdCall), SuppressUnmanagedCodeSecurity]
            public delegate int DllMain(IntPtr instance, int reason, IntPtr reserved);

            [UnmanagedFunctionPointer(StdCall), SuppressUnmanagedCodeSecurity]
            public delegate IntPtr GetProcAddress(IntPtr module, string name);
        }
    }
}