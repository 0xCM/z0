//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static OpacityKind;
    
    partial struct sys
    {
        [MethodImpl(NotInline), Opaque(GetGenericTypeCode), Closures(Closure)]
        public static TypeCode typecode<T>()
            => Type.GetTypeCode(typeof(T));

        [MethodImpl(NotInline), Opaque(GetTypeCode)]
        public static TypeCode typecode(Type src)
            => Type.GetTypeCode(src);
    }
}