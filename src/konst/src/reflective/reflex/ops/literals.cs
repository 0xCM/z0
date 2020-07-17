//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static Span<FieldInfo> literals(in Indexed<FieldInfo> src, Span<FieldInfo> dst)
        {
            var k = 0u;            
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
                if(IsLiteral(skip(view,i)))
                    seek(dst, k++) = skip(view,i);
            return slice(dst,k);                    
        }

        [MethodImpl(Inline), Op]
        public static Span<FieldInfo> literals(Type src, Span<FieldInfo> dst)
            => literals(fields(src), dst);    

        public static EnumLiterals literals(ClrEnum src)
        {
            var @base = src.BaseType.Metadata;
            var fields = span(@base.LiteralFields());
            var count = fields.Length;
            var nk = @base.NumericKind();
            var indices = sys.alloc<EnumLiteral>(count);
            var dst = span(indices);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var constval = field.GetRawConstantValue();
                var value = Variant.define(field.GetRawConstantValue(), nk);
                seek(dst, i) = new EnumLiteral(field, nk, i, field.Name, value);
            }
            return indices.ToIndex();
        }

    }
}