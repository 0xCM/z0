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

    using EC = ClrPrimalKind;

    partial struct ClrPrimitives
    {
        [Op]
        public static Index<SymbolicLiteral> enums(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = alloc<SymbolicLiteral>(fields.Length);
            fill(src, kind(src), fields, dst);
            return dst;
        }

        [Op]
        public static Index<SymbolicLiteral<E>> enums<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            var fields = span(src.LiteralFields());
            var dst = alloc<SymbolicLiteral<E>>(fields.Length);
            fill(src, kind(src), fields, span(dst));
            return dst;
        }

        [Op]
        public static ulong encode(ClrPrimalKind kind, object src)
            => kind switch {
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
        static void fill(Type type, ClrPrimalKind kind, ReadOnlySpan<FieldInfo> fields, Span<SymbolicLiteral> dst)
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
                row.DataType = kind;
                row.Position = (ushort)i;
                row.Name = f.Name;
                row.UniqueName = SymbolicLiterals.identity(simple, type.Name, row.Position, f.Name);
                row.EncodedValue = encode(kind, f.GetRawConstantValue());
            }
        }

        [Op]
        static void fill<E>(Type type, ClrPrimalKind kind, ReadOnlySpan<FieldInfo> fields, Span<SymbolicLiteral<E>> dst)
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
                row.Position = (ushort)i;
                row.Component = simple;
                row.Type = type.Name;
                row.DataType = kind;
                row.Name = f.Name;
                row.UniqueName = SymbolicLiterals.identity(simple, type.Name, row.Position, f.Name);
                row.DirectValue = (E)f.GetRawConstantValue();
                row.EncodedValue = encode(kind, row.DirectValue);
            }
        }
    }
}