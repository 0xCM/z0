//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static math;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BitsF128
    {
        [FieldOffset(0)]
        public decimal Data;

        [FieldOffset(0)]
        public ulong LoBits;

        [FieldOffset(8)]
        public ulong HiBits;

        [MethodImpl(Inline)]
        public BitsF128(decimal src)
            : this()
        {
            Data = src;
        }
    }
}