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
    public readonly struct ThreadStoreData
    {
        public readonly int ThreadCount;

        public readonly int UnstartedThreadCount;

        public readonly int BackgroundThreadCount;

        public readonly int PendingThreadCount;

        public readonly int DeadThreadCount;

        public readonly ClrDataAddress FirstThread;

        public readonly ClrDataAddress FinalizerThread;

        public readonly ClrDataAddress GCThread;

        public readonly uint HostConfig;
    }
}