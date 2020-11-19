//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void load<T>(in TableFields fields, ReadOnlySpan<T> src, in TableRows<T> dst)
            where T : struct
        {
            var count = (uint)src.Length;
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                load(fields, i, skip(src, i), ref seek(target,i));
        }

        [Op, Closures(Closure)]
        public static void load<T>(in TableFields fields, uint index, in T src, ref TableRow<T> dst)
            where T : struct
        {
            dst = dst.UpdateSource(index, src);
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = fields.View;
            var target = span(dst.Cells);
            for(var i=0u; i<count; i++)
                seek(target, i) = skip(fv, i).Definition.GetValueDirect(tr);
        }

        [Op]
        public static TableFieldEval load(object src, TableFields fields, Action<Exception> handler = null)
        {
            var buffer = alloc<NamedValue<object>>(fields.Length);
            var dst = span(buffer);
            var view = fields.View;
            var count = fields.Length;
            for(ushort i=0; i<count; i++)
            {
                try
                {
                    ref readonly var field = ref fields[i];
                    var name = field.Name;
                    var value = sys.value(src, field.Definition);
                    seek(dst,i) = (name, value);
                }
                catch(Exception e)
                {
                    if(handler != null)
                        handler(e);
                    else
                        term.print(e);
                }
            }
            return new TableFieldEval(src, fields, buffer);
        }

        [Op]
        public static TableFieldValues<F,T> load<F,T>(T src, TableFields<F> fields, Action<Exception> handler = null)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var buffer = alloc<NamedValue<object>>(fields.Count);
            var dst = span(buffer);
            for(ushort i=0; i<fields.Count; i++)
            {
                try
                {
                    ref readonly var field = ref fields[i];
                    seek(dst,i) = (field.Name, field.Definition.GetValue((int)i));
                }
                catch(Exception e)
                {
                    if(handler != null)
                        handler(e);
                    else
                        term.print(e);
                }
            }
            return new TableFieldValues<F,T>(src, fields, buffer);
        }
    }
}