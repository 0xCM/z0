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

    [ApiHost(ApiNames.ClrEnums, true)]
    public readonly struct ClrEnums
    {
        [Op]
        public static ClrEnumLiteralRecord[] literals(Assembly src)
        {
            var types = src.GetTypes().Where(t => t.IsEnum);
            var dst = list<ClrEnumLiteralRecord>();
            for(var i=0; i<types.Length; i++)
                dst.AddRange(literals(types[i]));
            return dst.ToArray();
        }

        [Op]
        public static ClrEnumLiteralRecord[] literals(Type src)
        {
            var ut = src.GetEnumUnderlyingType();
            var nk = ut.NumericKind();

            var fields = span(src.LiteralFields());
            var count = fields.Length;
            var buffer = sys.alloc<ClrEnumLiteralRecord>(count);
            var index = span(buffer);
            var assembly = src.Assembly;
            var part = assembly.Id();

            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                fill(part, field,i, ref seek(index, i));
            }

            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static ref ClrEnumLiteralRecord fill(PartId part, FieldInfo field, uint index, ref ClrEnumLiteralRecord dst)
        {
            dst.PartId = part;
            dst.TypeId = field.DeclaringType.MetadataToken;
            dst.TypeName = field.DeclaringType.Name;
            dst.FieldId = field.MetadataToken;
            dst.FieldName = field.Name;
            dst.DataType = field.DeclaringType.EnumScalarKind();
            dst.LiteralValue = (ulong)rebox(field.GetRawConstantValue(), UInt64k);
            dst.Position = index;
            return ref dst;
        }
    }
}