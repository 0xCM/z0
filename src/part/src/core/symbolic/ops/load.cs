//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        /// <summary>
        /// Symbol cache loader
        /// </summary>
        /// <typeparam name="E"></typeparam>
        internal static Symbols<E> load<E>()
            where E : unmanaged, Enum
        {
            var src = discover<E>();
            var count = src.Length;
            var buffer = alloc<Sym<E>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new Sym<E>(i, skip(src,i));
            return buffer;
        }

        static Span<SymLiteral<E>> discover<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            ClrAssemblyName component = src.Assembly;
            var fields = @readonly(src.LiteralFields());
            var count = fields.Length;

            var dst = span<SymLiteral<E>>(count);
            var kind = ClrPrimitives.kind(src);
            var counter = 0u;
            for(var i=z16; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                var tag = f.Tag<SymbolAttribute>();
                ref var row = ref seek(dst,i);
                var expr = tag ? tag.Value.Symbol : f.Name;
                row.Component = component;
                row.Type = src.Name;
                row.DataType = kind;
                row.Position = i;
                row.Name = f.Name;
                row.Symbol = expr;
                row.DirectValue = (E)f.GetRawConstantValue();
                row.ScalarValue = Enums.@ulong(kind, row.DirectValue);
                row.Description = tag.MapValueOrDefault(a => a.Description, EmptyString);
                row.Identity = identity(f, i, expr);
                row.Hidden = f.Ignored();
            }

            return dst;
        }
    }
}