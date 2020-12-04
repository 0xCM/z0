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
    /// Defines an 8-bit memory operand
    /// </summary>
    public struct MemOp8 : IMemOp<MemOp8,W8,byte>
    {
        public byte Value;

        [MethodImpl(Inline)]
        public MemOp8(byte src)
            => Value = src;

        byte IMemOp<byte>.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator MemOp8(byte src)
            => new MemOp8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(MemOp8 src)
            => src.Value;
    }
}