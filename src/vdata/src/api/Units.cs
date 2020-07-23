//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;
     
    partial class VData
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
                => z.vunits<T>(w);

        [MethodImpl(Inline)]
        public static Vector256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
                => z.vunits<T>(w);

        [MethodImpl(Inline)]
        public static Vector128<T> vunits<T>(Vec128Kind<T> kind)
            where T : unmanaged
                => vunits<T>(w128);

        [MethodImpl(Inline)]
        public static Vector256<T> vunits<T>(Vec256Kind<T> kind)
            where T : unmanaged
                => vunits<T>(w256);
    }
}