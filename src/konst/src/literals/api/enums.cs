//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Literals
    {        
        public static FieldValues<E,T> enums<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = fieldValues<T>(src); 
            var count = tValues.Length;
            var eValueBuffer = sys.alloc<EnumFieldValue<E,T>>(count);
            var dst = span(eValueBuffer);
            
            for(var i=0u; i<count; i++)
            {
                ref readonly var srcVal = ref tValues[i];
                ref readonly var tVal = ref srcVal.Value;
                ref readonly var srcField = ref srcVal.Field;
                seek(dst, i) = new EnumFieldValue<E,T>(srcField, read<E,T>(tVal), tVal);
            }
            
            return index(eValueBuffer);
        }
    }
}