//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;
    using static TaggedLiterals;

    using NBI = NumericBaseIndicator;

    partial class BitMasks
    {
        public static Index<BitMaskInfo> descriptions(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = list<BitMaskInfo>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(IsMultiLiteral(field))
                    dst.AddRange(descriptions(polymorphic(field), vRaw));
                else if(IsBinaryLiteral(field))
                    dst.Add(describe(binaryliteral(field,vRaw)));
                else
                    dst.Add(describe(NumericLiterals.literal(base2, field.Name, vRaw, BitRender.format(vRaw, tc))));
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
                var fenced = SymbolicQuery.fenced(input, fence);
                if(fenced)
                {
                    if(!FenceParser.unfence(input, fence, out content))
                        return sys.empty<BitMaskInfo>();
                }

                var components = @readonly(content.SplitClean(FieldDelimiter));
                var count = components.Length;
                var dst = alloc<BitMaskInfo>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var component = ref skip(components,i);
                    var length = component.Length;
                    if(length > 0)
                    {
                        var nbi = NumericBases.indicator(first(component));

                        if(nbi != 0)
                            seek(dst, i) = describe(NumericLiterals.literal(src.Name, value, component.Substring(1), NumericBases.kind(nbi)));
                        else
                        {
                            nbi = NumericBases.indicator(component[length - 1]);
                            nbi = nbi != 0 ? nbi : NBI.Base2;
                            seek(dst, i) = describe(NumericLiterals.literal(src.Name, value, component.Substring(0, length - 1), NumericBases.kind(nbi)));
                        }
                    }
                    else
                        seek(dst, i) = describe(NumericLiteral.Empty);
                }
            }

            return sys.empty<BitMaskInfo>();
        }
    }
}