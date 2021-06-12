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

    partial struct ClrLiterals
    {
        public static Index<ProvidedLiteral> provided(LiteralProvider src)
        {
            var fields = src.Definition.Fields().ReadOnly();
            var count = fields.Length;
            var buffer = alloc<ProvidedLiteral>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                ref var provided = ref seek(dst,i);
                var type = field.FieldType;
                var raw = field.GetRawConstantValue();
                var lk = ClrLiteralKind.None;
                var data = 0ul;
                if(type.IsEnum)
                {
                    var ekind = ClrPrimitives.ebase(type);
                    lk = (ClrLiteralKind)ekind;
                    data = serialize(raw,ekind);
                }
                else
                {
                    lk = (ClrLiteralKind)ClrPrimitives.kind(type);
                    data = serialize(raw,lk);
                }

                seek(dst,i) = new ProvidedLiteral(name(field), data, lk, src.Usage);
            }
            return buffer;
        }
    }
}