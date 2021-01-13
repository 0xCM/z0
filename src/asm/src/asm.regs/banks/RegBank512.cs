//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Cells;

    public readonly struct RegBank512
    {
        readonly Index<Cell512> Data;

        [MethodImpl(Inline)]
        internal RegBank512(Cell512[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref Cell128 r128(byte i)
            => ref c128(ref r512(i));

        [MethodImpl(Inline)]
        public ref Cell256 r256(byte i)
            => ref c256(ref r512(i));

        [MethodImpl(Inline)]
        public ref Cell512 r512(byte i)
            => ref Data[i];
    }
}