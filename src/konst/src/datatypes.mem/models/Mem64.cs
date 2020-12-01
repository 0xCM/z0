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
    public struct Mem64 : IMemOp<Mem64,W64,ulong>
    {
        public ulong Data;

        [MethodImpl(Inline)]
        public Mem64(ulong src)
            => Data = src;

        public DataWidth Width
            => DataWidth.W64;

        [MethodImpl(Inline)]
        public static implicit operator Mem64(ulong src)
            => new Mem64(src);

        [MethodImpl(Inline)]
        public static implicit operator Mem64(Cell64 src)
            => new Mem64(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator ulong(Mem64 src)
            => src.Data;
    }
}