//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static E undefined<E>(E e, E alt)
            where E : unmanaged, Enum
                => defined<E>(e) ? e : alt;
    }
}