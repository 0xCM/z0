//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Clr
    {
        [MethodImpl(Inline)]
        public static ClrEnum<E> @enum<E>()
            where E : unmanaged, Enum
                => default;
    }
}