//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;
    using static BVTypes;

    public static partial class BV
    {
        [MethodImpl(Inline)]
        public static Add<T> bvadd<T>(T t = default)
            where T : unmanaged        
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Sub<T> bvsub<T>(T t = default)
            where T : unmanaged        
                => Sub<T>.Op;
    }
}