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
    public struct Mem16 : IMemOp<Mem16,W16,ushort>
    {
        public ushort Data;

        [MethodImpl(Inline)]
        public Mem16(ushort src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Mem16(ushort src)
            => new Mem16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(Mem16 src)
            => src.Data;
    }
}