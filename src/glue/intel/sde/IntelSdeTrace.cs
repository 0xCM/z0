//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct IntelSdeTrace
    {
        public struct Instruction
        {
            public ulong Sequence;

            public MemoryAddress Address;

            public ByteBlock64 Expression;
        }

        public struct ReadAction<T>
            where T : unmanaged
        {
            public MemoryAddress Source;

            public byte Size;

            public byte Type;

            public T Value;
        }

        public struct WriteAction<T>
            where T : unmanaged
        {
            public MemoryAddress Target;

            public byte Size;

            public byte Type;

            public T Value;
        }
    }
}