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
        public static EnumLiteralDetails enums(Assembly src)
        {
            var types = src.GetTypes().Where(t => t.IsEnum);
            var dst = EnumLiteralDetails.Empty;
            for(var i=0; i<types.Length; i++)
                dst = dst.Append(Literals.enums(types[i]));
            return dst;
        }

        [Op]
        public static EnumLiteralDetails enums(Type src)
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

        public static EnumLiteral[] enums<E>()
            where E : unmanaged, Enum
        {
            var literals = Enums.index<E>();
            var count = literals.Length;
            var dst = new EnumLiteral[count];
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>();
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.Base10);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hexmax = bitmax != null ? bitmax.Value/4 : (int?)null;
            var declarer = typeof(E).Name;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                var description = tagged(typeof(E).Field(literal.ToString()).Require()).Text;
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();
                var bs = @base == NumericBaseKind.Base2 ? Formatters.value().FormatEnum(literal.LiteralValue, n2, bitmax) : EmptyString;
                var hex = Formatters.value().FormatEnum(literal.LiteralValue, n16, hexmax);
                dst[i] = new EnumLiteral(declarer, literal.Position, literal.Name, hex, bs, description);
            }

            return dst;
        }

        public static FieldValues<E,T> enums<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = fields<T>(src);
            var count = tValues.Length;
            var eValueBuffer = sys.alloc<EnumFieldValue<E,T>>(count);
            var dst = span(eValueBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var srcVal = ref tValues[i];
                ref readonly var tVal = ref srcVal.Value;
                ref readonly var srcField = ref srcVal.Field;
                seek(dst, i) = new EnumFieldValue<E,T>(srcField, read<E,T>(tVal), tVal);
            }

            return index(eValueBuffer);
        }

        [Op]
        public static void enums(PartId part, Type type, EnumTypeCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRecord> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRecord(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)ecode, Enums.unbox(ecode, f.GetRawConstantValue()));
            }
        }

        [Op]
        public static ReadOnlySpan<EnumLiteralRecord> enums(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRecord>(fields.Length);
            var ecode = PrimalKinds.ecode(src);
            enums(part, src, ecode, fields, dst);
            return dst;
        }
    }
}