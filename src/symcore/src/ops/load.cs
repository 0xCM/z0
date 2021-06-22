//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct Symbols
    {
        [Op]
        static SymIdentity identity(FieldInfo field, ushort index, SymExpr expr)
            => string.Format("{0:D3}:{1}:{2}::{3}.{4}({5})",
                    index,
                    RP.bracket((CliToken)field),
                    field.DeclaringType.Assembly.GetSimpleName(),
                    field.DeclaringType.FullName,
                    field.Name,
                    expr);

        static Dictionary<string,Sym<K>> lookup<K>(Index<Sym<K>> src)
            where K : unmanaged
        {
            var count = src.Length;
            var view = src.View;
            var dst = dict<string,Sym<K>>();
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(view,i);
                dst.TryAdd(symbol.Expr.Text, symbol);
            }

            return dst;
        }

        [Op, Closures(Closure)]
        internal static Sym untyped<T>(Sym<T> src)
            where T : unmanaged
                => new Sym(src.Identity, src.Key, src.Type, bw64(src.Kind), src.Name, src.Expr, src.Description, src.Hidden);

        /// <summary>
        /// Symbol cache loader
        /// </summary>
        internal static Symbols<E> load<E>()
            where E : unmanaged, Enum
        {
            var src = discover<E>();
            var count = src.Length;
            var buffer = alloc<Sym<E>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new Sym<E>(i, skip(src,i));
            return new Symbols<E>(buffer, lookup<E>(buffer));
        }

        static Span<SymLiteral<E>> discover<E>()
            where E : unmanaged, Enum
        {
            var src = typeof(E);
            ClrAssemblyName component = src.Assembly;
            var fields = src.LiteralFields().ToReadOnlySpan();
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
                var litval = (E)f.GetRawConstantValue();
                row.Component = component;
                row.Type = src.Name;
                row.DataType = kind;
                row.Position = i;
                row.Name = f.Name;
                row.Symbol = (litval,expr);
                row.ScalarValue = Enums.@ulong(kind, litval);
                row.Description = tag.MapValueOrDefault(a => a.Description, EmptyString);
                row.Identity = identity(f, i, expr);
                row.Hidden = f.Ignored();
            }

            return dst;
        }
    }
}