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

    [ApiHost]
    public readonly struct ApiLiterals
    {
        [MethodImpl(Inline), Op]
        public static LiteralProvider provider(Type src, LiteralUsage usage = default)
            => new LiteralProvider(src,usage);


        public static string format(in ApiLiteral src)
            => string.Format("{0,-16} | {1,-16} | {2,-12} | {3}", src.Source, src.Name, src.Kind, value(src));
        [Op]
        public static ApiLiteralValue value(in ApiLiteral src)
        {
            var value = EmptyString;
            if(src.Kind == ClrLiteralKind.String)
                value = ((StringAddress)src.Content).Format();
            else
                value = src.Content.ToString();
            return value;
        }

        [Op]
        public static ApiLiteralSpec specify(in ApiLiteral src)
        {
            var dst = default(ApiLiteralSpec);
            dst.Source = src.Source.Format();
            dst.Name = src.Name.Format();
            dst.Kind = src.Kind.ToString();
            dst.Value = src.Value();
            return dst;
        }

        [Op]
        public static Index<LiteralProvider> providers(Assembly src)
            => providers(src.TaggedTypes<LiteralProviderAttribute>());

        [Op]
        public static Index<LiteralProvider> providers(Assembly[] src)
            => providers(src.TaggedTypes<LiteralProviderAttribute>());

        [MethodImpl(Inline), Op]
        static Index<LiteralProvider> providers(ReadOnlySpan<TaggedType<LiteralProviderAttribute>> types)
        {
            var count = types.Length;
            var buffer = alloc<LiteralProvider>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                seek(dst,i) = provider(type.Type, type.Tag.Usage);
            }
            return buffer;
        }

        [Op]
        public static Index<ApiLiteral> provided(LiteralProvider src)
        {
            var fields = src.Definition.Fields().ReadOnly();
            var count = fields.Length;
            var buffer = alloc<ApiLiteral>(count);
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
                    data = ClrLiterals.serialize(raw,ekind);
                }
                else
                {
                    lk = (ClrLiteralKind)ClrPrimitives.kind(type);
                    data = ClrLiterals.serialize(raw,lk);
                }

                seek(dst,i) = new ApiLiteral(ClrLiterals.name(field.DeclaringType), ClrLiterals.name(field), data, lk);
            }
            return buffer;
        }
    }
}