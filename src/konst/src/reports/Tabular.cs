//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;
    
    public readonly struct Tabular
    {
        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        public const ushort PosMask = 0xFFFF;

        public static TableStore<F,R> Store<F,R>()
            where F : unmanaged, Enum
            where R : ITabular
                => default;

        // [MethodImpl(Inline)]
        // public static Tabular<F,R> Proxy<F,R>(R record, Func<R,char,string> formatter)
        //     where F : unmanaged, Enum
        //     where R : ITabular
        //         => new Tabular<F,R>(record,formatter);

        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static TabularFormat<F> Specify<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var literals = @readonly(DataFields.literals<F>());
            var count = literals.Length;
            var headBuffer = sys.alloc<string>(count);
            var fieldBuffer = sys.alloc<TabularField<F>>(count);            
            var fields = span(fieldBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);                
                seek(fields,i) = new TabularField<F>(literal, literal.ToString(), (int)i, (short)(uint32(literal) >> WidthOffset));                
            }
            
            return new TabularFormat<F>(fieldBuffer);
        }

        /// <summary>
        /// Computes the field index from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int Index<F>(F field)
            where F : unmanaged, Enum
                => Dataset.index(field);

        /// <summary>
        /// Computes the field width from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int Width<F>(F field)
            where F : unmanaged, Enum
                => Dataset.width(field);
    
        [MethodImpl(Inline)]
        public static string[] Headers<F>()
            where F : unmanaged, Enum
                => Dataset.labels<F>();    

        /// <summary>
        /// Creates a record formatter predicated on an enum that specifies the record fields
        /// </summary>
        /// <typeparam name="F">The field specification type</typeparam>
        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> Formatter<F>()
            where F :unmanaged, Enum
                => Dataset.formatter<F>();

        [MethodImpl(Inline)]
        public static RecordFormatter<F,W> Formatter<F,W>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where W : unmanaged, Enum
                => new RecordFormatter<F,W>(text.build(), delimiter);

        /// <summary>
        /// Creates a record formatter predicated on a field definition set defined by an enum
        /// </summary>
        /// <param name="sep">The default field delimiter</param>
        /// <typeparam name="F">The type of the defining enum</typeparam>
        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> Formatter<F>(char sep)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), sep);
                
        [MethodImpl(Inline)]
        public static DatasetHeader<F> Header<F>()
            where F : unmanaged, Enum
                => Dataset.header<F>();

        [MethodImpl(Inline)]
        public static string HeaderText<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => Header<F>().Render(delimiter);

        /// <summary>
        /// Formates a header row using a caller-supplied label producer
        /// </summary>
        /// <param name="f">The label factory</param>
        /// <param name="delimiter">The delimiter</param>
        /// <typeparam name="F">The field type</typeparam>
        [MethodImpl(Inline)]
        public static string HeaderText<F>(Func<int,F,string> f, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => Header<F>().Render(f,delimiter);

        public static ParallelQuery<string> Render<R>(R[] src, Func<R,string> formatter)
            where R : IRecord
                => from r in src.AsParallel()
                   let f = formatter(r)
                   orderby r.Sequence
                   select f;

        public static R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatter, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where R : IRecord
        {
            var header = Tabular.Header<F>();
            using var writer = dst.Writer();            
            writer.WriteLine(header.Render(delimiter)); 
            
            var rendered = Render(src,formatter).ToArray();

            for(var i=0; i< rendered.Length; i++)
                writer.WriteLine(rendered[i]);   

            return src;         
        }            

        public R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatRecord, Func<int,F,string> formatLabel, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where R : IRecord
        {
            var header = Tabular.Header<F>();
            using var writer = dst.Writer();            
            writer.WriteLine(header.Render(formatLabel, delimiter)); 
            
            var rendered = Render(src,formatRecord).ToArray();
            for(var i=0; i< rendered.Length; i++)
                writer.WriteLine(rendered[i]);   

            return src;         
        }            

        public static Option<FilePath> Save<F,R>(R[] src, FilePath dst, FileWriteMode mode = Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
                => Save<F,R>(src, Tabular.Specify<F>(), dst, mode);

        public static Option<FilePath> Save<F,R>(R[] data, TabularFormat format, FilePath dst, FileWriteMode mode = Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
        {                
            if(data == null || data.Length == 0)
                return Option.none<FilePath>();

            try
            {
                dst.FolderPath.Create();                            
                var overwrite = mode == Overwrite;
                var emitHeader = format.EmitHeader && (overwrite || !dst.Exists);                
                
                using var writer = dst.Writer(mode);

                if(emitHeader)
                {
                    var header = Tabular.Header<F>();
                    writer.WriteLine(header.Render(format.Delimiter));
                }

                iter(data, r => writer.WriteLine(r.DelimitedText(format.Delimiter)));   
                return dst;                             
            }
            catch(Exception e)
            {
                term.error(e);                
                return Option.none<FilePath>();
            }
        }                         
    }
}