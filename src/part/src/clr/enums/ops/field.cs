//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct ClrEnums
    {
        [MethodImpl(Inline)]
        public static ClrEnumField<E> field<E>(uint index, FieldInfo src, E value)
            where E : unmanaged, Enum
                => new ClrEnumField<E>(index,src,value);
    }
}