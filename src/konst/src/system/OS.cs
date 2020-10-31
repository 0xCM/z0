//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using Fp = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

    public readonly partial struct OS
    {
        [DllImport(Kernel32), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport(Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "LoadLibraryW"), Free]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport(Kernel32), Free]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        public readonly struct Delegates
        {
            [Fp(StdCall), Free]
            public delegate int DllMain(IntPtr instance, int reason, IntPtr reserved);

            [Fp(StdCall), Free]
            public delegate IntPtr GetProcAddress(IntPtr module, string name);

            [Fp(StdCall), Free]
            public delegate int AddRefDelegate(IntPtr self);

            [Fp(StdCall), Free]
            public delegate int ReleaseDelegate(IntPtr self);

            [Fp(StdCall), Free]
            public delegate int QueryInterfaceDelegate(IntPtr self, in Guid guid, out IntPtr ptr);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct IUnknownVTable
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
        }
    }
}