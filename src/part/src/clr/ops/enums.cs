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
        public static ReadOnlySpan<EnumLiteral> enums(ClrAssemblyName assembly, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteral>(fields.Length);
            var ecode = ClrPrimitives.ecode(src);
            fill(assembly, src, ecode, fields, dst);
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
        static void fill(ClrAssemblyName assembly, Type type, ClrEnumCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteral> dst)
        {
            var count = fields.Length;
            var typeAddress = type.TypeHandle.Value;
            var asmName = assembly.SimpleName;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                row.Component = asmName;
                row.Type = type.Name;
                row.DataType = ecode;
                row.LiteraIndex = (ushort)i;
                row.LiteralName = f.Name;
                row.ScalarValue = unbox(ecode, f.GetRawConstantValue());
                row.NameAddress = memory.address(f.Name);
                row.TypeAddress = typeAddress;
            }
        }
    }
}