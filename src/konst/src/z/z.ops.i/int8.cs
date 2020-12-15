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
        public static sbyte int8<T>(T src)
            => memory.int8(src);

        [MethodImpl(Inline)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => memory.int8(src);

        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(ref T src)
            => ref memory.int8(ref src);
    }
}