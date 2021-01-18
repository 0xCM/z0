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
    /// Defines a 64-bit memory operand
    /// </summary>
    public struct MemOp64 : IMemOp<MemOp64,W64,ulong>
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public MemOp64(ulong src)
            => Value = src;

        public DataWidth Width
            => DataWidth.W64;

        [MethodImpl(Inline)]
        public static implicit operator MemOp64(ulong src)
            => new MemOp64(src);

        [MethodImpl(Inline)]
        public static implicit operator MemOp64(Cell64 src)
            => new MemOp64(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemOp64 src)
            => src.Value;
    }
}