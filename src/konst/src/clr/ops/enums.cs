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

    partial struct Clr
    {
        [Op]
        public static Index<SymbolicLiteral> enums(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = alloc<SymbolicLiteral>(fields.Length);
            enums(src, dst);
            return dst;
        }

        public static void enums(Type src, Span<SymbolicLiteral> dst)
        {
            var fields = span(src.LiteralFields());
            var ecode = ClrPrimitives.kind(src);
            fill(src, ecode, fields, dst);
        }

        [Op]
        public static Index<SymbolicLiteral> enums(Index<Type> src)
        {
            var dst = root.list<SymbolicLiteral>();
            var kTypes = src.Count;
            for(var i=0; i<kTypes; i++)
            {
                var type = src[i];
                dst.AddRange(enums(type));
            }

            return dst.Array();
        }

        [Op]
        public static Index<SymbolicLiteral> enums(params Assembly[] src)
        {
            var kvTypes = ClrEnums.types(src);
            var partCount = kvTypes.Length;
            var dst = root.list<SymbolicLiteral>();
            for(var i=0; i<partCount; i++)
            {
                var types = kvTypes[i];
                var kTypes = types.Length;
                for(var j=0u; j<kTypes; j++)
                {
                    var kv = types[j];
                    (var asm, var type) = kv;
                    var lits = enums(type);
                    var kLits = lits.Length;
                    for(var k=0; k<kLits; k++)
                        dst.Add(lits[k]);
                }
            }
            return dst.ToArray();
        }

        [Op]
        static void fill(Type type, ClrPrimalKind kind, ReadOnlySpan<FieldInfo> fields, Span<SymbolicLiteral> dst)
        {
            var count = fields.Length;
            var typeAddress = type.TypeHandle.Value;
            var asmName = type.Assembly.GetSimpleName();
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                row.Component = asmName;
                row.Type = type.Name;
                row.DataType = kind;
                row.Position = (ushort)i;
                row.Name = f.Name;
                row.EncodedValue = ClrEnums.unbox(kind, f.GetRawConstantValue());
                row.Symbol = f.Tag<SymbolAttribute>().MapValueOrDefault(a => a.Symbol, f.Name);
            }
        }
    }
}