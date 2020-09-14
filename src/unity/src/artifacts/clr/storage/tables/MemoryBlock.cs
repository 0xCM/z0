//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct ClrStorage
    {
        public unsafe struct MemoryBlock
        {
            public byte* Buffer;

            public int Length;

            public MemoryBlock(byte* buffer, int length)
            {
                Buffer = buffer;
                Length = length;
            }

            public MemoryBlock(byte* buffer, uint length)
            {
                Buffer = buffer;
                Length = (int)length;
            }
        }

    }
}