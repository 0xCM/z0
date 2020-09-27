//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitLogix
    {
        [MethodImpl(Inline), Op]
        public static Bit32 not(Bit32 a)
            => !a;

        [MethodImpl(Inline), Op]
        public static Bit32 identity(Bit32 a)
            => a;

        [MethodImpl(Inline), Op]
        public static Bit32 @false(Bit32 a)
            => Bit32.Off;

        [MethodImpl(Inline), Op]
        public static Bit32 @true(Bit32 a)
            => Bit32.On;
    }
}