//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Literals
    {
        [MethodImpl(Inline)]
        public static FieldValues<E,T> index<E,T>(EnumFieldValue<E,T>[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new FieldValues<E,T>(src);
    }
}