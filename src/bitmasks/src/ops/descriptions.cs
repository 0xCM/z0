//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;
    using static TextRules;
    using static TaggedLiterals;

    using NBI = NumericBaseIndicator;

    partial class BitMasks
    {
        public static Index<BitMaskInfo> descriptions(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = root.list<BitMaskInfo>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(IsMultiLiteral(field))
                    dst.AddRange(descriptions(polymorphic(field), vRaw));
                else if(IsBinaryLiteral(field))
                    dst.Add(BitMasks.describe(binaryliteral(field,vRaw)));
                else
                    dst.Add(BitMasks.describe(Numeric.literal(base2, field.Name, vRaw, BitFormatter.format(vRaw, tc))));
            }
            return dst.ToArray();
        }

        public static Index<BitMaskInfo> descriptions(LiteralInfo src, object value)
        {
            if(src.Polymorphic)
            {
                var input = src.Text;
                var fence = Rules.fence(Chars.LBracket, Chars.RBracket);
                var content = input;
                var fenced = Query.fenced(input, fence);
                if(fenced)
                {
                    if(!text.unfence(input, fence, out content))
                        return sys.empty<BitMaskInfo>();
                }

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
                            dst[i] = describe(Numeric.literal(src.Name, value, component.Substring(1), NumericBases.kind(nbi)));
                        else
                        {
                            nbi = NumericBases.indicator(component[length - 1]);
                            nbi = nbi != 0 ? nbi : NBI.Base2;
                            dst[i] = BitMasks.describe(Numeric.literal(src.Name, value, component.Substring(0, length - 1), NumericBases.kind(nbi)));
                        }
                    }
                    else
                        dst[i] = describe(NumericLiteral.Empty);
                }
            }

            return sys.empty<BitMaskInfo>();
        }
    }
}