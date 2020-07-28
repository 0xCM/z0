//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JitCodeHeapInfo
    {
        public readonly CodeHeapType Type;
        public readonly ClrDataAddress Address;
        public readonly ClrDataAddress CurrentAddress;
    }
}