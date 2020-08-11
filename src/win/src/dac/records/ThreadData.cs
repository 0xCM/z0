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
        public readonly uint ManagedThreadId;

        public readonly uint OSThreadId;

        public readonly int State;

        public readonly uint PreemptiveGCDisabled;

        public ClrDataAddress AllocationContextPointer;

        public ClrDataAddress AllocationContextLimit;

        public ClrDataAddress Context;

        public ClrDataAddress Domain;

        public ClrDataAddress Frame;

        public readonly uint LockCount;

        public ClrDataAddress FirstNestedException;

        public ClrDataAddress Teb;

        public ClrDataAddress FiberData;

        public ClrDataAddress LastThrownObjectHandle;

        public ClrDataAddress NextThread;
    }
}