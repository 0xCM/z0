//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    using O = OpacityApiClass;

    partial struct proxy
    {
        [MethodImpl(Options), Opaque(O.GetGenericType), Closures(Closure)]
        public static Type type<T>()
            => typeof(T);

        [MethodImpl(Options), Opaque(O.GetInstanceType)]
        public static Type type(object src)
            => src?.GetType() ?? typeof(void);
    }
}