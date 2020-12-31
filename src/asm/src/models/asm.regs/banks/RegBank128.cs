//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RegBank128
    {
        readonly Index<Cell128> Data;

        [MethodImpl(Inline)]
        internal RegBank128(Cell128[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref Cell128 r128(byte i)
            => ref Data[i];
    }
}