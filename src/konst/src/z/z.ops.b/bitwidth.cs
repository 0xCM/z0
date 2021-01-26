//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static uint bitwidth<T>(T t = default)
            => memory.bitwidth<T>();

        [MethodImpl(Inline)]
        public static byte bitwidth<T>(W8 w)
            => memory.bitwidth<T>(w);

        [MethodImpl(Inline)]
        public static ushort bitwidth<T>(W16 w)
            => memory.bitwidth<T>(w);

        [MethodImpl(Inline)]
        public static uint bitwidth<T>(W32 w)
            => memory.bitwidth<T>(w);

        [MethodImpl(Inline)]
        public static ulong bitwidth<T>(W64 w)
            => memory.bitwidth<T>(w);

        [MethodImpl(Inline)]
        public static BitSize bitsize<T>()
            => memory.bitsize<T>();
    }
}