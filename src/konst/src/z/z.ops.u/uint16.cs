//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ushort uint16<T>(T src)
            => memory.uint16(src);

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(ref T src)
            => ref memory.uint16(ref src);

        [MethodImpl(Inline)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => memory.uint16(ref src);
    }
}