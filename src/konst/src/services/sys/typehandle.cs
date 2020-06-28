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
        [MethodImpl(Options), Opaque(GetTypeHandle)]
        public static IntPtr typehandle(Type src) 
            => src.TypeHandle.Value;

        [MethodImpl(Options), Opaque(GetGenericTypeHandle), Closures(Closure)]
        public static IntPtr typehandle<T>() 
            => typeof(T).TypeHandle.Value;
    }
}