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

    using static ClrDataModel;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct SyncBlockData
    {
        public readonly ClrDataAddress Object;

        public readonly uint Free;

        public readonly ClrDataAddress Address;

        public readonly uint COMFlags;

        public readonly uint MonitorHeld;

        public readonly uint Recursion;

        public readonly ClrDataAddress HoldingThread;

        public readonly uint AdditionalThreadCount;

        public readonly ClrDataAddress AppDomain;

        public readonly uint TotalSyncBlockCount;
    }
}