//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [Op]
        public static FieldEvaluation evaluate(Type src, TableFields fields, Action<Exception> handler = null)
        {
            var buffer = alloc<NamedValue<object>>(fields.Count);
            var dst = span(buffer);
            for(ushort i=0; i<fields.Count; i++)
            {
                try
                {
                    ref readonly var field = ref fields[i];
                    seek(dst,i) = (field.Name, skip(fields.Data,i).GetValue((int)i));
                }
                catch(Exception e)
                {
                    if(handler != null)
                        handler(e);
                    else
                        term.print(e);
                }
            }
            return new FieldEvaluation(src, fields, buffer);
        }

        [Op]
        public static FieldEvaluation<F,T> evaluate<F,T>(T src, TableFields<F> fields, Action<Exception> handler = null)
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
                    seek(dst,i) = (field.Name, skip(fields.Data,i).GetValue((int)i));
                }
                catch(Exception e)
                {
                    if(handler != null)
                        handler(e);
                    else
                        term.print(e);
                }
            }
            return new FieldEvaluation<F,T>(fields, buffer);
        }
    }
}