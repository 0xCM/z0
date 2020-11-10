//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using NBI = NumericBaseIndicator;

    partial class BitMasks
    {
        public static BitMaskRow[] rows(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = new List<BitMaskRow>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(rows(Z0.Literals.multiliteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(BitMasks.row(LiteralAttributes.BinaryLiteral(field,vRaw)));
                else
                    dst.Add(BitMasks.row(NumericLiterals.base2(field.Name, vRaw, BitFormatter.bits(vRaw, tc))));
            }
            return dst.ToArray();
        }

        public static BitMaskRow[] rows(LiteralInfo src, object value)
        {
            if(src.MultiLiteral)
            {
                var content = text.unbracket(src.Text);
                if(!text.blank(content))
                {
                    var components = content.SplitClean(FieldDelimiter);
                    var count = components.Length;
                    var dst = alloc<BitMaskRow>(count);
                    for(var i=0; i<count; i++)
                    {
                        var component = components[i];
                        var length = component.Length;
                        if(length > 0)
                        {
                            var indicator = NumericBases.indicator(component[0]);

                            if(indicator != 0)
                                dst[i] = row(NumericLiterals.define(src.Name, value, component.Substring(1), NumericBases.kind(indicator)));
                            else
                            {
                                indicator = NumericBases.indicator(component[length - 1]);
                                indicator = indicator != 0 ? indicator : NBI.Base2;
                                dst[i] = BitMasks.row(NumericLiterals.define(
                                    src.Name,
                                    value,
                                    component.Substring(0, length - 1),
                                    NumericBases.kind(indicator)
                                    ));
                            }
                        }
                        else
                            dst[i] = row(NumericLiteral.Empty);
                    }
                }
            }
            return sys.empty<BitMaskRow>();
        }
    }
}