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

    partial struct ClrEnums
    {
        [Op]
        public static Index<SymbolicLiteral<E>> symbolic<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            ClrAssemblyName component = src.Assembly;
            var fields = @readonly(src.LiteralFields());
            var count = fields.Length;

            var buffer = alloc<SymbolicLiteral<E>>(fields.Length);
            var dst = span(buffer);
            var kind = ClrPrimitives.kind(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                row.Component = component;
                row.Type = src.Name;
                row.DataType = kind;
                row.Position = (ushort)i;
                row.Name = f.Name;
                var tag = f.Tag<SymbolAttribute>();
                if(tag)
                    row.Symbol = tag.Value.Symbol;
                else
                    row.Symbol = f.Name;
                row.DirectValue = (E)f.GetRawConstantValue();
                row.UniqueName = SymbolicLiterals.identity(component.SimpleName, src.Name, row.Position, f.Name);
                row.EncodedValue = ClrPrimitives.encode(kind, row.DirectValue);
                row.Description = tag.MapValueOrDefault(a => a.Description, EmptyString);
            }

            return buffer;
        }

        [Op]
        public static Index<SymbolicLiteral> symbolic(Type src)
        {
            var fields = @readonly(src.LiteralFields());
            var dst = alloc<SymbolicLiteral>(fields.Length);
            symbolic(src, dst);
            return dst;
        }

        public static void symbolic(Type src, Span<SymbolicLiteral> dst)
        {
            var fields = @readonly(src.LiteralFields());
            var ecode = ClrPrimitives.kind(src);
            fill(src, ecode, fields, dst);
        }

        [Op]
        public static Index<SymbolicLiteral> symbolic(Index<Type> src)
        {
            var dst = root.list<SymbolicLiteral>();
            var kTypes = src.Count;
            for(var i=0; i<kTypes; i++)
                dst.AddRange(symbolic(src[i]));

            return dst.Array();
        }

        [Op]
        public static Index<SymbolicLiteral> symbolic(params Assembly[] src)
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
                    var lits = symbolic(type);
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

            ClrAssemblyName component = type.Assembly;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                var tag = f.Tag<SymbolAttribute>();
                row.Component = component;
                row.Type = type.Name;
                row.DataType = kind;
                row.Position = (ushort)i;
                row.Name = f.Name;
                row.EncodedValue = ClrEnums.unbox(kind, f.GetRawConstantValue());
                row.Symbol = tag.MapValueOrDefault(a => a.Symbol, f.Name);
                row.Description = tag.MapValueOrDefault(a => a.Description, EmptyString);
            }
        }
    }
}