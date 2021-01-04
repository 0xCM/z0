//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static math;

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct BitsF32
    {
        public const uint SignMask = 0x7fffffff;

        [FieldOffset(0)]
        public float Data;

        [FieldOffset(0)]
        public uint Bits;

        [MethodImpl(Inline)]
        public BitsF32(float src)
        {
            Bits = 0;
            Data = src;
        }
    }
}