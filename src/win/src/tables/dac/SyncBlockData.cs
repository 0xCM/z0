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
    public struct SyncBlockData
    {
        public ClrDataAddress Object;

        public uint Free;

        public ClrDataAddress Address;

        public uint COMFlags;

        public uint MonitorHeld;

        public uint Recursion;

        public ClrDataAddress HoldingThread;

        public uint AdditionalThreadCount;

        public ClrDataAddress AppDomain;

        public uint TotalSyncBlockCount;
    }
}