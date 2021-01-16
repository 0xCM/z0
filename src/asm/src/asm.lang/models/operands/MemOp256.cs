//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    /// <summary>
    /// Defines a 256-bit memory operand
    /// </summary>
    public struct MemOp256 : IMemOp<MemOp256,W256,Cell256>
    {
        public Cell256 Value;

        [MethodImpl(Inline)]
        public MemOp256(Cell256 src)
            => Value = src;

        Cell256 IMemOp<Cell256>.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator MemOp256(Cell256 src)
            => new MemOp256(src);

        [MethodImpl(Inline)]
        public static implicit operator MemOp256(Vector256<ulong> src)
            => new MemOp256(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(MemOp256 src)
            => src.Value;
    }
}