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
    public struct ThreadStoreData
    {
        public int ThreadCount;

        public int UnstartedThreadCount;

        public int BackgroundThreadCount;

        public int PendingThreadCount;

        public int DeadThreadCount;

        public ClrDataAddress FirstThread;

        public ClrDataAddress FinalizerThread;

        public ClrDataAddress GCThread;

        public uint HostConfig;
    }
}