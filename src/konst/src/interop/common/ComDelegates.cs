//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Security;

    using static Konst;

    public readonly struct ComDelegates
    {
        [UnmanagedFunctionPointer(StdCall), SuppressUnmanagedCodeSecurity]
        public delegate int AddRefDelegate(IntPtr self);

        [UnmanagedFunctionPointer(StdCall), SuppressUnmanagedCodeSecurity]
        public delegate int ReleaseDelegate(IntPtr self);

        [UnmanagedFunctionPointer(StdCall), SuppressUnmanagedCodeSecurity]
        public delegate int QueryInterfaceDelegate(IntPtr self, in Guid guid, out IntPtr ptr);
    }
}