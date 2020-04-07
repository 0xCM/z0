//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T generic<T>(sbyte src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref sbyte src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static sbyte int8<T>(T src)
            => As.int8(src);

        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(ref T src)
            => ref As.int8(ref src);

        [MethodImpl(Inline)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => As.int8(src);
    }
}