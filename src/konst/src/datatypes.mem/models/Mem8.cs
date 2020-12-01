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
    public struct Mem8 : IMemOp<Mem8,W8,byte>
    {
        public byte Data;

        [MethodImpl(Inline)]
        public Mem8(byte src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Mem8(byte src)
            => new Mem8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(Mem8 src)
            => src.Data;
    }
}