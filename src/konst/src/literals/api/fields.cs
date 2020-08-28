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

    partial struct Literals
    {
        /// <summary>
        /// Collects unmanaged fields defined by a type
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FieldValues<T> fields<T>(Type src)
            where T : unmanaged
                => search<T>(src).Select(f => (f, sys.constant<T>(f)));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public FieldValues<T> fields<T>(Type[] types)
            where T : unmanaged
        {
            var literals = list<FieldValue<T>>();
            for(var i=0u; i<types.Length; i++)
            {
                var values = fields<T>(types[i]).ToSpan();
                for(var j=0u; j<values.Length; j++)
                    literals.Add(skip(values,j));
            }
            return sys.array(literals);
        }

        public static FieldValues<E,T> fields<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = fields<T>(src);
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