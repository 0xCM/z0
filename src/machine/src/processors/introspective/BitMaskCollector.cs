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
    using static Root;

    public readonly struct BitMaskCollector
    {
        public static NumericLiteral[] collect()
        {
            var fields = span(typeof(BitMasks).LiteralFields());
            var dst = new List<NumericLiteral>();
            for(var i = 0; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(Literati.numeric(LiteralAttributes.MultiLiteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(LiteralAttributes.BinaryLiteral(field,vRaw));
                else
                    dst.Add(NumericLiteral.Base2(field.Name, vRaw, BitFormatter.format(vRaw, tc)));
            }
            return dst.ToArray();            
        }
    }
}