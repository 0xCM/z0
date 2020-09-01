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

    public readonly struct BoundValueSource
    {        
        [MethodImpl(Inline)]
        public static T next<T>(IBoundValueSource source, T max)
            where T : struct
                => source.Next<T>(max);

        [MethodImpl(Inline)]
        public static T next<T>(IBoundValueSource source, T min, T max)
            where T : struct
                => source.Next<T>(min, max);                
    }    
}