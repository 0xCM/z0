//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ValueSource
    {        
        [MethodImpl(Inline)]
        public static T next<T>(IValueSource source, T t = default)
            where T : struct
                => source.Next<T>();
    }
}