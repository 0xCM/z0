//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;

    partial class Enums
    {
        public static Index<T> numeric<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => ClrLiterals.search<E>(typeof(E)).Select(f => sys.constant<T>(f));

        public static EnumFieldValues<E,T> values<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = LiteralFields.values<T>(src);
            var count = tValues.Length;
            var eValueBuffer = memory.alloc<EnumFieldValue<E,T>>(count);
            var dst = span(eValueBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var srcVal = ref tValues[i];
                ref readonly var tVal = ref srcVal.Right;
                ref readonly var srcField = ref srcVal.Left;
                seek(dst, i) = new EnumFieldValue<E,T>(srcField, EnumValue.read<E,T>(tVal), tVal);
            }

            return index(eValueBuffer);
        }
    }
}