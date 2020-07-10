//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    partial struct sys
    {
        [MethodImpl(Options), Op]
        public static bool equals(object lhs, object rhs)
            => proxy.equals(lhs,rhs);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static bool equals<T>(T lhs, T rhs)
            where T : struct
                => proxy.equals(lhs,rhs);
    }
}