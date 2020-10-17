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

    using static Konst;
    using static z;

    using NBK = NumericBaseKind;
    using NBI = NumericBaseIndicator;

    partial struct Literals
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
                => z.map(search<T>(src),numeric<T>);

        public static NumericLiteral[] numeric(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = new List<NumericLiteral>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(numeric(multiliteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(LiteralAttributes.BinaryLiteral(field,vRaw));
                else
                    dst.Add(NumericLiteral.base2(field.Name, vRaw, BitFormatter.bits(vRaw, tc)));
            }
            return dst.ToArray();
        }

        public static NumericLiteral[] numeric(LiteralInfo src, object value)
        {
            if(src.MultiLiteral)
            {
                var content = text.unbracket(src.Text);
                if(!text.blank(content))
                {
                    var components = content.SplitClean(Chars.Pipe);
                    var count = components.Length;
                    var dst = sys.alloc<NumericLiteral>(count);
                    for(var i=0; i<components.Length; i++)
                    {
                        var component = components[i];
                        var length = component.Length;
                        if(length > 0)
                        {
                            var indicator = NumericBases.indicator(component[0]);

                            if(indicator != 0)
                                dst[i] = NumericLiteral.define(src.Name, value, component.Substring(1), NumericBases.kind(indicator));
                            else
                            {
                                indicator = NumericBases.indicator(component[length - 1]);
                                indicator = indicator != 0 ? indicator : NBI.Base2;
                                dst[i] = NumericLiteral.define(
                                    src.Name,
                                    value,
                                    component.Substring(0, length - 1),
                                    NumericBases.kind(indicator)
                                    );
                            }
                        }
                        else
                            dst[i] = NumericLiteral.Empty;
                    }
                }
            }
            return sys.empty<NumericLiteral>();
        }
    }
}