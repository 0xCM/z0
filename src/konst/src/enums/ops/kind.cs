//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static ClrEnumKind kind(Type e)
        {
            var tc = Type.GetTypeCode(e.GetEnumUnderlyingType());
            return (ClrEnumKind)ClrPrimitives.kind(tc);
        }

        [MethodImpl(Inline)]
        public static ClrEnumKind kind<E>(E e = default)
            where E : unmanaged, Enum
                => kind(typeof(E));
    }
}