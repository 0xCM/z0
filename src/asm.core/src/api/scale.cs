//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static MemoryScale scale(N1 n)
            => new MemoryScale(ScaleFactor.S1);

        [MethodImpl(Inline), Op]
        public static MemoryScale scale(N2 n)
            => new MemoryScale(ScaleFactor.S2);

        [MethodImpl(Inline), Op]
        public static MemoryScale scale(N4 n)
            => new MemoryScale(ScaleFactor.S4);

        [MethodImpl(Inline), Op]
        public static MemoryScale scale(N8 n)
            => new MemoryScale(ScaleFactor.S8);

        [MethodImpl(Inline), Op]
        public static MemoryScale scale(byte factor)
            => new MemoryScale((ScaleFactor)factor);

        [MethodImpl(Inline), Op]
        public static MemoryScale scale(ScaleFactor factor)
            => new MemoryScale(factor);
    }
}