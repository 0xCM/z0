//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct SymbolicLiterals
    {
        [Op]
        public static SymIdentity identity(FieldInfo field, ushort index)
            => text.format(RP.SlotDot4, field.DeclaringType.Assembly.GetSimpleName(), field.DeclaringType.Name, index, field.Name);

        public static Index<SymLiteral<E>> load<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            ClrAssemblyName component = src.Assembly;
            var fields = @readonly(src.LiteralFields());
            var count = fields.Length;

            var buffer = alloc<SymLiteral<E>>(fields.Length);
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
                row.Identity = identity(f, row.Position);
                row.EncodedValue = ClrPrimitives.encode(kind, row.DirectValue);
                row.Description = tag.MapValueOrDefault(a => a.Description, EmptyString);
            }

            return buffer;
        }

        [Op]
        public static Index<SymLiteral> symbolic(Type src)
        {
            var fields = @readonly(src.LiteralFields());
            var dst = alloc<SymLiteral>(fields.Length);
            fill(src, ClrPrimitives.kind(src), fields, dst);
            return dst;
        }

        [Op]
        public static Index<SymLiteral> symbolic(Index<Type> src)
        {
            var dst = root.list<SymLiteral>();
            var kTypes = src.Count;
            for(var i=0; i<kTypes; i++)
                dst.AddRange(symbolic(src[i]));

            return dst.Array();
        }

        [Op]
        public static Index<SymLiteral> symbolic(params Assembly[] src)
        {
            var kvTypes = ClrEnums.types(src);
            var partCount = kvTypes.Length;
            var dst = root.list<SymLiteral>();
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
        static void fill(Type type, ClrPrimalKind kind, ReadOnlySpan<FieldInfo> fields, Span<SymLiteral> dst)
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