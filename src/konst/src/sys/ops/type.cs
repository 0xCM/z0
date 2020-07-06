//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Konst;

    using O = OpacityKind;

    partial struct sys
    {        
        [MethodImpl(Options), Opaque(O.GetGenericType), Closures(AllNumeric)]
        public static Type type<T>()
            => typeof(T);

        [MethodImpl(Options), Opaque(O.GetInstanceType)]
        public static Type type(object src)
            => src?.GetType() ?? typeof(void);
    }
}