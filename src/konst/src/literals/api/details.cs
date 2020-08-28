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

    partial struct Literals
    {
        [Op]
        public static EnumLiteralDetails details(Assembly src)
        {
            var types = src.GetTypes().Where(t => t.IsEnum);
            var dst = EnumLiteralDetails.Empty;
            for(var i=0; i<types.Length; i++)
                dst = dst.Append(Literals.details(types[i]));
            return dst;
        }

        [Op]
        public static EnumLiteralDetails details(Type src)
        {
            var ut = src.GetEnumUnderlyingType();
            var nk = ut.NumericKind();

            var fields = span(src.LiteralFields());
            var count = fields.Length;
            var buffer = sys.alloc<EnumLiteralDetail>(count);
            var index = span(buffer);

            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var dst = new EnumLiteralDetail();
                dst.Id = Reflex.identity(field);
                dst.TypeName = src.Name;
                dst.PrimalKind = Enums.@base(nk);
                dst.LiteralName = field.Name;
                dst.Position = i;
                dst.ScalarValue = Variant.define(field.GetRawConstantValue(), nk);
                seek(index,i) = dst;
            }

            return new EnumLiteralDetails(buffer);
        }
    }
}