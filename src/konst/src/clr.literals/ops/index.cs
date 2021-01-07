//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline)]
        public static EnumFieldValues<E,T> index<E,T>(EnumFieldValue<E,T>[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumFieldValues<E,T>(src);
    }
}