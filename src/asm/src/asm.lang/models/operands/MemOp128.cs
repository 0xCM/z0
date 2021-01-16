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
    /// Defines a 128-bit memory operand
    /// </summary>
    public struct MemOp128 : IMemOp<MemOp128,W128,Cell128>
    {
        public Cell128 Value;

        [MethodImpl(Inline)]
        public MemOp128(Cell128 src)
            => Value = src;

        Cell128 IMemOp<Cell128>.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator MemOp128(Cell128 src)
            => new MemOp128(src);

        [MethodImpl(Inline)]
        public static implicit operator MemOp128(Vector128<ulong> src)
            => new MemOp128(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(MemOp128 src)
            => src.Value;
    }
}