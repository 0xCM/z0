//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    using NBI = NumericBaseIndicator;

    public readonly struct ReflectedLiterals
    {
        public static LiteralInfo attributed(FieldInfo target)
        {
            var tagged = target.Tagged<LiteralAttribute>();
            if(tagged)
            {
                var attrib = (LiteralAttribute)target.GetCustomAttribute(typeof(LiteralAttribute));
                var data = attrib.Description;
                if(!string.IsNullOrWhiteSpace(data))
                    return LiteralInfo.Define(target.Name,
                    target.GetRawConstantValue(), data,
                    Type.GetTypeCode(target.FieldType),
                    target.FieldType.IsEnum,
                    false);
            }
            return LiteralInfo.Empty;
        }

        public static NumericLiteral[] find(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = new List<NumericLiteral>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(numeric(LiteralAttributes.MultiLiteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(LiteralAttributes.BinaryLiteral(field,vRaw));
                else
                    dst.Add(NumericLiteral.Base2(field.Name, vRaw, Render.bits(vRaw, tc)));
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
                                dst[i] = NumericLiteral.Define(src.Name, value, component.Substring(1), NumericBases.kind(indicator));
                            else
                            {
                                indicator = NumericBases.indicator(component[length - 1]);
                                indicator = indicator != 0 ? indicator : NBI.Base2;
                                dst[i] = NumericLiteral.Define(
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
            return Array.Empty<NumericLiteral>();
        }
    }
}