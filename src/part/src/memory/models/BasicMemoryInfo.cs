//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    public struct BasicMemoryInfo
    {
        public MemoryAddress BaseAddress;

        public MemoryAddress AllocationBase;

        public ByteSize RegionSize;

        public ByteSize StackSize;

        public MemoryPageProtection Protection;
    }
}