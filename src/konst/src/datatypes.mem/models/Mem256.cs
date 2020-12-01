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
    public struct Mem256 : IMemOp<Mem256,W256,Cell256>
    {
        public Cell256 Data;

        [MethodImpl(Inline)]
        public Mem256(Cell256 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Mem256(Cell256 src)
            => new Mem256(src);

        [MethodImpl(Inline)]
        public static implicit operator Mem256(Vector256<ulong> src)
            => new Mem256(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(Mem256 src)
            => src.Data;
    }
}