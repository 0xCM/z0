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
    public struct Mem32 : IMemOp<Mem32,W32,uint>
    {
        public uint Data;

        [MethodImpl(Inline)]
        public Mem32(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Mem32(uint src)
            => new Mem32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Mem32 src)
            => src.Data;
    }
}