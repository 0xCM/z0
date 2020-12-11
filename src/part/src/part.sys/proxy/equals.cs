//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using O = OpacityApiClass;

    partial struct proxy
    {
        [MethodImpl(Options), Opaque(O.Equals)]
        public static bool equals(object lhs, object rhs)
            => object.Equals(lhs,rhs);

        [MethodImpl(Options), Opaque(O.Equals), Closures(Closure)]
        public static bool equals<T>(T lhs, T rhs)
            where T : struct
                => lhs.Equals(rhs);
    }
}