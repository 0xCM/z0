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

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using Fp = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

    public readonly partial struct OS
    {
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
    }
}