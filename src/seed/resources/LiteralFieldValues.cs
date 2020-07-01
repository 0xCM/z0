//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static Root;
    using static As;
    using static LiteralFields;
    using LF = LiteralFields;

    [ApiHost]
    public readonly struct LiteralFieldValues
    {
        [Op]
        public static object value(FieldInfo src)
            => src.GetRawConstantValue();
        
        [Op]
        public static char[] chars(Type src)
            => search<char>(src).Select(@char);

        [Op]
        public static char @char(FieldInfo f)
            => (char)f.GetRawConstantValue();

        [Op]
        public static string @string(FieldInfo f)
            => (string)f.GetRawConstantValue();

        [Op]
        public static string[] strings(Type src)
            => LF.strings(src).Select(@string);

        [Op, Closures(UInt64k)]
        public static T value<T>(FieldInfo f)
            => (T)f.GetRawConstantValue();

        public static T[] values<T>(Type src)
            => search<T>(src).Select(value<T>);

        [Op, Closures(UInt64k)]
        public static T numeric<T>(FieldInfo f)
            where T : unmanaged
                => (T)f.GetRawConstantValue();

        [Op, Closures(UInt64k)]
        public static T[] numeric<T>(Type src)
            where T : unmanaged
                => search<T>(src).Select(numeric<T>);

        [Op, Closures(UInt64k)]
        public static FieldValues<T> from<T>(Type src)
            where T : unmanaged
                => search<T>(src).Select(f => (f,(T)f.GetRawConstantValue()));        

        [Op, Closures(UInt64k)]
        public FieldValues<T> numeric<T>(Type[] types)
            where T : unmanaged
        {
            var literals = list<FieldValue<T>>();
            for(var i=0; i<types.Length; i++)
            {
                var values = from<T>(types[i]).ToSpan();
                for(var j=0; j<values.Length; j++)
                    literals.Add(skip(values,j));
            }
            return literals.ToArray();
        }

        [Op]
        public static FieldValues<E,T> enums<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = from<T>(src); 
            var count = tValues.Length;
            var eValueBuffer = alloc<FieldValue<E,T>>(count);
            var dst = span(eValueBuffer);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var srcVal = ref tValues[i];
                ref readonly var tVal = ref srcVal.Value;
                ref readonly var srcField = ref srcVal.Field;

                seek(dst, i) = new FieldValue<E,T>(srcField, literal<E,T>(tVal), tVal);
            }
            
            return index(eValueBuffer);
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static FieldValues<E,T> index<E,T>(FieldValue<E,T>[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new FieldValues<E,T>(src);

        [MethodImpl(Inline)]
        static unsafe E literal<E,T>(in T tVal, E eRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>(gptr<T,E>(tVal));
    }
}