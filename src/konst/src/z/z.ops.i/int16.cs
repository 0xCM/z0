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
        public static short int16<T>(T src)
            => memory.int16(src);

        [MethodImpl(Inline)]
        public static short? int16<T>(T? src)
            where T : unmanaged
                => memory.int16(src);

        [MethodImpl(Inline)]
        public static ref short int16<T>(ref T src)
            => ref memory.int16(ref src);
    }
}