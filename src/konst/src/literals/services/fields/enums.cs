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
    using static z;

    partial struct LiteralFields
    {
        public static FieldValues<E,T> enums<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = from<T>(src); 
            var count = tValues.Length;
            var eValueBuffer = sys.alloc<FieldValue<E,T>>(count);
            var dst = span(eValueBuffer);
            
            for(var i=0u; i<count; i++)
            {
                ref readonly var srcVal = ref tValues[(int)i];
                ref readonly var tVal = ref srcVal.Value;
                ref readonly var srcField = ref srcVal.Field;

                seek(dst, i) = new FieldValue<E,T>(srcField, literal<E,T>(tVal), tVal);
            }
            
            return index(eValueBuffer);
        }

        [MethodImpl(Inline)]
        static unsafe E literal<E,T>(in T tVal, E eRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>(gptr<T,E>(tVal));        
    }
}