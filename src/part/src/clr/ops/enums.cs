//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    using EC = ClrEnumCode;

    partial struct ClrPrimitives
    {
        [Op]
        public static Index<EnumLiteral> enums(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = alloc<EnumLiteral>(fields.Length);
            var ecode = ClrPrimitives.ecode(src);
            fill(src, ecode, fields, dst);
            return dst;
        }

        [Op]
        public static Index<EnumLiteral<E>> enums<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            var fields = span(src.LiteralFields());
            var dst = alloc<EnumLiteral<E>>(fields.Length);
            var ecode = ClrPrimitives.ecode(src);
            fill(src, ecode, fields, span(dst));
            return dst;
        }

        [Op]
        public static ulong unbox(EC ec, object src)
            => ec switch {
                EC.U8 => (ulong)(byte)src,
                EC.I8 => (ulong)(sbyte)src,
                EC.U16 => (ulong)(ushort)src,
                EC.I16 => (ulong)(short)src,
                EC.U32 => (ulong)(uint)src,
                EC.I32 => (ulong)(int)src,
                EC.I64 => (ulong)(long)src,
                EC.U64 => (ulong)src,
                _ => 0ul,
            };

        [Op]
        static void fill(Type type, ClrEnumCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteral> dst)
        {
            ClrAssemblyName assname = type.Assembly;
            var count = fields.Length;
            var typeAddress = type.TypeHandle.Value;
            var simple = assname.SimpleName;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                row.Component = simple;
                row.Type = type.Name;
                row.DataType = ecode;
                row.LiteraIndex = (ushort)i;
                row.LiteralName = f.Name;
                row.ScalarValue = unbox(ecode, f.GetRawConstantValue());
                row.NameAddress = memory.address(f.Name);
                row.TypeAddress = typeAddress;
            }
        }

        [Op]
        static void fill<E>(Type type, ClrEnumCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteral<E>> dst)
            where E : unmanaged, Enum
        {
            ClrAssemblyName assname = type.Assembly;
            var count = fields.Length;
            var typeAddress = type.TypeHandle.Value;
            var simple = assname.SimpleName;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                row.Index = (ushort)i;
                row.Component = simple;
                row.Type = type.Name;
                row.DataType = ecode;
                row.Name = f.Name;
                row.LiteralValue = (E)f.GetRawConstantValue();
                row.ScalarValue = unbox(ecode, row.LiteralValue);
            }
        }
    }
}