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

    public readonly struct RegBank64
    {
        readonly Index<Cell64> Data;

        [MethodImpl(Inline)]
        internal RegBank64(Cell64[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref Cell8 r8(byte i)
            => ref lo8(ref r64(i));

        [MethodImpl(Inline)]
        public ref Cell16 r16(byte i)
            => ref lo16(ref r64(i));

        [MethodImpl(Inline)]
        public ref Cell32 r32(byte i)
            => ref lo32(ref r64(i));

        [MethodImpl(Inline)]
        public ref Cell64 r64(byte i)
            => ref Data[i];
    }
}