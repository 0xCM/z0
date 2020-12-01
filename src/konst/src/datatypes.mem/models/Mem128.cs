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
    public struct Mem128 : IMemOp<Mem128,W128,Cell128>
    {
        public Cell128 Data;

        [MethodImpl(Inline)]
        public Mem128(Cell128 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Mem128(Cell128 src)
            => new Mem128(src);

        [MethodImpl(Inline)]
        public static implicit operator Mem128(Vector128<ulong> src)
            => new Mem128(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(Mem128 src)
            => src.Data;
    }
}