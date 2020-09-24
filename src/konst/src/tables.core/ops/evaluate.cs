//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Table
    {
        [Op]
        public static TableFieldEval evaluate(object src, TableFields fields, Action<Exception> handler = null)
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
        public static TableFieldValues<F,T> evaluate<F,T>(T src, TableFields<F> fields, Action<Exception> handler = null)
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