//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ClrEnums
    {
        [MethodImpl(Inline)]
        public static unsafe E read<E,T>(in T scalar, E e = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>(gptr<T,E>(scalar));
    }
}