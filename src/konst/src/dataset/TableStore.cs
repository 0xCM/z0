//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static z;
    
    public readonly partial struct TableStore
    {
        public static TableHeader<F> header<F>()
            where F : unmanaged, Enum
        {
            var fields = typeof(F).LiteralFields();
            var count = fields.Length;
            var values = alloc<F>(count);
            ref var v = ref first(span(values));
            ref readonly var f = ref first(span(fields));
            for(var i=0; i<count; i++)
                seek(v,i) = (F)f.GetRawConstantValue();
            return new TableHeader<F>(fields, values);
        }        

        public static void deposit<F,R>(R[] src, FilePath dst, IRowFormatter<F> formatter, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where R : ITable
        {
            var header = header<F>();
            var count = (uint)src.Length;
            var rows = span(src);
            using var writer = dst.Writer();            
            writer.WriteLine(header.HeaderText(delimiter));
            
            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));                 
        }            
    }
}