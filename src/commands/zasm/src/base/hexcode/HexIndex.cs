//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class HexIndex
    {
        [MethodImpl(Inline)]
        public static HexIndex<T> Define<T>(params HexKindValue<T>[] src)
            where T : unmanaged
                => HexIndex.Define<T>(src);

        [MethodImpl(Inline)]
        public static HexIndex<T> Define<T>(Func<T,HexKind> hfunc, params T[] src)
            where T : unmanaged
                => new HexIndex<T>(hfunc, src);

        [MethodImpl(Inline)]
        public static HexIndex<T> Empty<T>()
            where T : unmanaged
                => HexIndex.Define<T>();
    }
}