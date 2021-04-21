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
        internal static Symbols<E> load<E>()
            where E : unmanaged, Enum
        {
            var src = literals<E>();
            var view = src.View;
            var count = view.Length;
            var buffer = alloc<Sym<E>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new Sym<E>(i, skip(view,i));
            return buffer;
        }

        internal static Index<SymLiteral<E>> literals<E>()
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
    }
}