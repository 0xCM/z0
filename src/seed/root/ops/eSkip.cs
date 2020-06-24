//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static ref readonly T eSkip<E,T>(ReadOnlySpan<T> src, E field)
            where E : unmanaged, Enum
                => ref skip(src, scalar<E,ushort>(field));                    
    }

}