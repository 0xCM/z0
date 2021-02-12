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
        public static uint width<T>(T t = default)
            => memory.width<T>(w32);

        [MethodImpl(Inline)]
        public static byte bitwidth<T>(W8 w)
            => memory.width<T>(w);

        [MethodImpl(Inline)]
        public static ushort bitwidth<T>(W16 w)
            => memory.width<T>(w);

        [MethodImpl(Inline)]
        public static uint bitwidth<T>(W32 w)
            => memory.width<T>(w);

        [MethodImpl(Inline)]
        public static ulong bitwidth<T>(W64 w)
            => memory.width<T>(w);

        [MethodImpl(Inline)]
        public static BitWidth bitsize<T>()
            => memory.width<T>();
    }
}