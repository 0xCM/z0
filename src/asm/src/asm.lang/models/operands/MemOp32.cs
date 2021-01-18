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
    /// Defines a 32-bit memory operand
    /// </summary>
    public struct MemOp32 : IMemOp<MemOp32,W32,uint>
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public MemOp32(uint src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator MemOp32(uint src)
            => new MemOp32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(MemOp32 src)
            => src.Value;
    }
}