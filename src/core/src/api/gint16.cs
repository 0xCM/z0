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
        public static T generic<T>(short src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref short src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static short int16<T>(T src)
            => As.int16(src);

        [MethodImpl(Inline)]
        public static ref short int16<T>(ref T src)
            => ref As.int16(ref src);

        [MethodImpl(Inline)]
        public static short? int16<T>(T? src)
            where T : unmanaged
                => As.int16(src);
    }
}