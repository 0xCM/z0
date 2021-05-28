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
    using static core;

    using NBK = NumericBaseKind;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline)]
        public static unsafe V numeric<E,V>(E src)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> numeric<T>(string Name, T data, string Text, NBK @base)
            where T : unmanaged
                => new NumericLiteral<T>(Name,data, Text, @base);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T numeric<T>(FieldInfo f)
            where T : unmanaged
                => sys.constant<T>(f);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] numeric<T>(Type src)
            where T : unmanaged
                => map(search<T>(src),numeric<T>);

        public static Index<NumericLiteral> numeric(Type src, Base2 b)
        {
            var fields = span(src.LiteralFields());
            var dst = list<NumericLiteral>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                dst.Add(Numeric.literal(field.Name, vRaw, BitFormatter.format(vRaw, tc), b));
            }
            return dst.ToArray();
        }
    }
}