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

    partial struct ComInterop
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct IUnknownVTable
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
        }
    }
}