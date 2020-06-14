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
    using static Control;

    partial class BitMask
    {                                   
        public static ReadOnlySpan<NumericLiteral> NumericLiterals
        {
            [MethodImpl(Inline)]
            get => _NumericLiterals.Value;
        }

        static NumericLiteral[] CreateLiterals()
        {
            ReadOnlySpan<FieldInfo> fields = typeof(BitMasks).LiteralFields();
            var dst = new List<NumericLiteral>();
            for(var i = 0; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(MultiLiteralAttribute.Attached(field))
                    dst.AddRange(Literati.numeric(MultiLiteralAttribute.TargetValue(field), vRaw));
                else if(BinaryLiteralAttribute.Attached(field))
                    dst.Add(BinaryLiteralAttribute.TargetValue(field,vRaw));
                else
                    dst.Add(NumericLiteral.Base2(field.Name, vRaw, BitFormatter.unsigned(vRaw, tc)));
            }
            return dst.ToArray();            
        }

        static Lazy<NumericLiteral[]> _NumericLiterals {get;} 
            = defer(CreateLiterals);
    }
}