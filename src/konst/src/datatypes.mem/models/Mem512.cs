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
    /// Defines a 512-bit memory operand
    /// </summary>
    public struct Mem512 : IMemOp<Mem512,W512,Cell512>
    {
        public Cell512 Data;

        [MethodImpl(Inline)]
        public Mem512(Cell512 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Mem512(Cell512 src)
            => new Mem512(src);

        [MethodImpl(Inline)]
        public static implicit operator Mem512(Vector512<ulong> src)
            => new Mem512(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell512(Mem512 src)
            => src.Data;
    }
}