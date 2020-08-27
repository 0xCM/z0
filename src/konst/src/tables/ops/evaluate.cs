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
        public static FieldEval evaluate(Type src, TableFields fields, Action<Exception> handler = null)
        {
            var buffer = alloc<NamedValue<object>>(fields.Count);
            var dst = span(buffer);
            for(ushort i=0; i<fields.Count; i++)
            {
                try
                {
                    ref readonly var field = ref fields[i];
                    ref readonly var data = ref skip(fields.View,i);
                    var name = field.Name;
                    var value = sys.value(data, field.Definition);
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
            return new FieldEval(src, fields, buffer);
        }

        [Op]
        public static FieldEval<F,T> evaluate<F,T>(T src, TableFields<F> fields, Action<Exception> handler = null)
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
            return new FieldEval<F,T>(fields, buffer);
        }
    }
}