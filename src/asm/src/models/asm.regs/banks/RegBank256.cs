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

    public readonly struct RegBank256
    {
        readonly Index<Cell256> Data;

        [MethodImpl(Inline)]
        internal RegBank256(Cell256[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref Cell128 r128(byte i)
            => ref c128(ref r256(i));

        [MethodImpl(Inline)]
        public ref Cell256 r256(byte i)
            => ref Data[i];
    }
}