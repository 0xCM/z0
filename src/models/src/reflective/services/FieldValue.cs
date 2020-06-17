//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct FieldValue
    {
        [MethodImpl(Inline)]
        public static FieldValue<E,T> from<E,T>(FieldInfo field, E eVal, T tVal)
            where E : unmanaged, Enum
            where T : unmanaged
                => new FieldValue<E,T>(field, eVal, tVal);
    }
}