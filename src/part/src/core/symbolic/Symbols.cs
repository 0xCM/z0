//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly partial struct Symbols
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymLiteral untyped<E>(in SymLiteral<E> src)
            where E : unmanaged
        {
            var dst = new SymLiteral();
            dst.Component = src.Component.SimpleName;
            dst.Type = src.Type;
            dst.Position = src.Position;
            dst.Name = src.Name;
            dst.Symbol = src.Symbol;
            dst.DataType = src.DataType;
            dst.ScalarValue = src.ScalarValue;
            dst.Description = src.Description;
            dst.Hidden = src.Hidden;
            dst.Identity = src.Identity;
            return dst;
        }

        public static Outcome parse(TextLine src, out SymLiteral dst)
        {
            var outcome = Outcome.Success;
            var j=0;
            var cells = src.Split(Chars.Pipe);
            if(cells.Length != SymLiteral.FieldCount)
            {
                dst = default;
                return (false, AppMsg.FieldCountMismatch.Format(SymLiteral.FieldCount,cells.Length));
            }

            outcome += DataParser.parse(skip(cells,j), out dst.Component);
            outcome += DataParser.parse(skip(cells,j), out dst.Type);
            outcome += DataParser.parse(skip(cells,j), out dst.Position);
            outcome += DataParser.parse(skip(cells,j), out dst.Name);
            outcome += DataParser.parse(skip(cells,j), out dst.Symbol);
            outcome += DataParser.eparse(skip(cells,j), out dst.DataType);
            outcome += DataParser.parse(skip(cells,j), out dst.ScalarValue);
            outcome += DataParser.parse(skip(cells,j), out dst.Hidden);
            outcome += DataParser.parse(skip(cells,j), out dst.Description);
            outcome += DataParser.parse(skip(cells,j), out dst.Identity);
            return outcome;
        }


        [Op]
        public static Index<SymLiteral> literals(Type src)
        {
            var fields = @readonly(src.LiteralFields());
            var dst = alloc<SymLiteral>(fields.Length);
            fill(src, ClrPrimitives.kind(src), fields, dst);
            return dst;
        }

        [Op]
        public static Index<SymLiteral> literals(Index<Type> src)
        {
            var dst = root.list<SymLiteral>();
            var kTypes = src.Count;
            for(var i=0; i<kTypes; i++)
                dst.AddRange(literals(src[i]));

            return dst.Array();
        }

        [Op]
        public static Index<SymLiteral> literals(Index<Assembly> src)
        {
            var kvTypes = Enums.types(src).View;
            var partCount = kvTypes.Length;
            var dst = root.list<SymLiteral>();
            for(var i=0; i<partCount; i++)
            {
                var types = skip(kvTypes,i).View;
                var kTypes = types.Length;
                for(var j=0u; j<kTypes; j++)
                {
                    (var asm, var type) = skip(types,j);
                    var syms = literals(type);
                    var kLits = syms.Length;
                    for(var k=0; k<kLits; k++)
                        dst.Add(syms[k]);
                }
            }
            return dst.ToArray();
        }

        [Op]
        static void fill(Type type, ClrPrimalKind kind, ReadOnlySpan<FieldInfo> fields, Span<SymLiteral> dst)
        {
            var count = fields.Length;

            var component = type.Assembly.GetSimpleName();
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
                row.ScalarValue = Enums.unbox(kind, f.GetRawConstantValue());
                row.Symbol = tag.MapValueOrDefault(a => a.Symbol, f.Name);
                row.Description = tag.MapValueOrDefault(a => a.Description, EmptyString);
                row.Hidden = f.Ignored();
            }
        }
   }
}