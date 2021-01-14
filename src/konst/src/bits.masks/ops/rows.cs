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
    using static TextRules;

    using NBI = NumericBaseIndicator;

    partial class BitMasks
    {
        public static BitMaskInfo[] rows(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = new List<BitMaskInfo>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(rows(Z0.ClrLiterals.multiliteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(BitMasks.row(LiteralAttributes.BinaryLiteral(field,vRaw)));
                else
                    dst.Add(BitMasks.row(Numeric.base2(field.Name, vRaw, BitFormatter.format(vRaw, tc))));
            }
            return dst.ToArray();
        }

        public static BitMaskInfo[] rows(LiteralInfo src, object value)
        {
            if(src.MultiLiteral)
            {
                var result = Parse.unbracket(src.Text);
                if(result)
                {
                    var content = result.Data;
                    var components = content.SplitClean(FieldDelimiter);
                    var count = components.Length;
                    var dst = alloc<BitMaskInfo>(count);
                    for(var i=0; i<count; i++)
                    {
                        var component = components[i];
                        var length = component.Length;
                        if(length > 0)
                        {
                            var nbi = NumericBases.indicator(component[0]);

                            if(nbi != 0)
                                dst[i] = row(Numeric.literal(src.Name, value, component.Substring(1), NumericBases.kind(nbi)));
                            else
                            {
                                nbi = NumericBases.indicator(component[length - 1]);
                                nbi = nbi != 0 ? nbi : NBI.Base2;
                                dst[i] = BitMasks.row(Numeric.literal(src.Name, value, component.Substring(0, length - 1), NumericBases.kind(nbi)));
                            }
                        }
                        else
                            dst[i] = row(NumericLiteral.Empty);
                    }
                }
            }
            return sys.empty<BitMaskInfo>();
        }
    }
}