//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using static Part;
    using static memory;
    using static TextRules;
    using static TaggedLiterals;

    using NBK = NumericBaseKind;
    using NBI = NumericBaseIndicator;

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
                => root.map(search<T>(src),numeric<T>);

        public static NumericLiteral[] numeric(Type src, Base2 b)
        {
            var fields = span(src.LiteralFields());
            var dst = root.list<NumericLiteral>();
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