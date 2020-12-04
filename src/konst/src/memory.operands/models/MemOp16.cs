//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a 16-bit memory operand
    /// </summary>
    public struct MemOp16 : IMemOp<MemOp16,W16,ushort>
    {
        public ushort Value;

        [MethodImpl(Inline)]
        public MemOp16(ushort src)
            => Value = src;

        ushort IMemOp<ushort>.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator MemOp16(ushort src)
            => new MemOp16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(MemOp16 src)
            => src.Value;
    }
}