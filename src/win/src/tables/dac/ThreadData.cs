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
    public struct ThreadData
    {
        public uint ManagedThreadId;

        public uint OSThreadId;

        public int State;

        public uint PreemptiveGCDisabled;

        public ClrDataAddress AllocationContextPointer;

        public ClrDataAddress AllocationContextLimit;

        public ClrDataAddress Context;

        public ClrDataAddress Domain;

        public ClrDataAddress Frame;

        public uint LockCount;

        public ClrDataAddress FirstNestedException;

        public ClrDataAddress Teb;

        public ClrDataAddress FiberData;

        public ClrDataAddress LastThrownObjectHandle;

        public ClrDataAddress NextThread;
    }
}