//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    public readonly struct Table : IDatasets
    {

        [MethodImpl(Inline)]
        public static TableHeader<F> header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableHeader<F>(fields<F>());

        [MethodImpl(Inline)]
        public static TableFields<F> fields<F>()
            where F : unmanaged, Enum
                => new TableFields<F>(typeof(F).LiteralFields());

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(TableFields<F> fields, StringBuilder dst = null)
            where F : unmanaged, Enum
                => new TableFormatter<F>(fields, dst);

        public static IDatasets Service => new Table(0);

        Table(int i)
        {
            
        }



        
        [MethodImpl(Inline)]
        public static F[] literals<F>()
            where F : unmanaged, Enum            
                => fields<F>().Literals;

        [MethodImpl(Inline)]
        public static short width<F>(F f)
            where F : unmanaged, Enum
                => fields<F>().Width(f);

        public static void append<F>(StringBuilder dst, F f, object content)   
            where F : unmanaged, Enum
        {
            dst.Append(render(dst, content).PadRight(width(f)));
        }

        static string render(StringBuilder dst, object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return t.Format();
            else
                return content.ToString();
        }    

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Literal<T> literal<T>(string declarer, string name, uint index, T value, LiteralKind kind, bool refinement)
            => new Literal<T>(declarer, name, index, value, kind, refinement);
                

        [MethodImpl(Inline)]
        public static Publication<R> publication<R>(R[] src, FilePath dst)
            where R : ITabular
                => new Publication<R>(src,dst);  


        public static void deposit<F,R>(R[] src, FilePath dst, IRowFormatter<F> formatter, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where R : ITable
        {
            var header = header<F>(delimiter);
            var count = (uint)src.Length;
            var rows = span(src);
            using var writer = dst.Writer();            
            writer.WriteLine(header.HeaderText);
            
            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));                 
        }            
    }    
}