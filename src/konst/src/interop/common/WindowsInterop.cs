//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Runtime.InteropServices;

    using static Konst;

    public readonly struct WindowsImports
    {
        [DllImport(Kernel32)][return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport(Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "LoadLibraryW")]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport(Kernel32)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
    }

    public readonly struct WindowsDelegates
    {
        [UnmanagedFunctionPointer(StdCall), SuppressUnmanagedCodeSecurity]
        public delegate int DllMain(IntPtr instance, int reason, IntPtr reserved);
    }
}