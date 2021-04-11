//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Windows;

    public struct BasicMemoryInfo
    {
        public MemoryAddress BaseAddress;

        public MemoryAddress AllocationBase;

        public ByteSize RegionSize;

        public ByteSize StackSize;

        public PageProtection AllocProtect;

        public PageProtection Protection;

        public MemState State;

        public MemType Type;
    }
}