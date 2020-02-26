//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public static class EnumX
    {
        [MethodImpl(Inline)]
        public static bool IsSome<E>(this E src)        
            where E : unmanaged, Enum            
                => !Enums.zero<E>().Equals(src);

        [MethodImpl(Inline)]
        public static bool IsNone<E>(this E src)        
            where E : unmanaged, Enum            
                => Enums.zero<E>().Equals(src);

        [MethodImpl(Inline)]
        public static T MapSomeOrElse<E,T>(this E kind, Func<E,T> ifSome, Func<T> ifNone)
            where E : unmanaged, Enum
                => kind.IsSome() ? ifSome(kind) : ifNone();
    }
}