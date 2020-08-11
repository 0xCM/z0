//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GCInfo
    {
        public readonly int ServerMode;

        public readonly int GCStructuresValid;

        public readonly int HeapCount;

        public readonly int MaxGeneration;
    }
}