//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public enum RecordFieldWidths
    {
        Id = 50,

        Sequence = 10,

        Count = 8,

        Mnemonic = 24,

        Instruction = 60,
        
        Register = 6,        

        Offset = 16,

        OpCode = 30,

        DataWidth = 26,

        OpKind = 12,

        Enc = 26,

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num8Dec = 8,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num8Hex = 8,

        /// <summary>
        /// The width of a field containing a boolean indicator [T/F, Y/N, 0/1, ..]
        /// </summary>
        Boolean = 8,

    }
    
    public enum RecordFields : uint
    {
        Include = 0,

        Exclude = Pow2.T31
    }

    public class Records
    {
        /// <summary>
        /// Creates a record formatter predicated on a field definition set defined by an enum
        /// </summary>
        /// <param name="sep">The default field delimiter</param>
        /// <typeparam name="F">The type of the defining enum</typeparam>
        [MethodImpl(Inline)]
        public static IRecordFormatter<F> Formatter<F>(char sep)
            where F : unmanaged, Enum
                => new RecordFormatter<F>(new StringBuilder(), sep);

        /// <summary>
        /// Creates a record formatter predicated on a field definition set defined by an enum
        /// </summary>
        /// <typeparam name="F">The type of the defining enum</typeparam>
        [MethodImpl(Inline)]
        public static IRecordFormatter<F> Formatter<F>()
            where F : unmanaged, Enum
                => new RecordFormatter<F>(new StringBuilder());

        [MethodImpl(Inline)]
        public static F[] Fields<F>()
            where F : unmanaged, Enum
                => Enums.valarray<F>();

        [MethodImpl(Inline)]
        public static string[] Headers<F>()
            where F : unmanaged, Enum
                => Fields<F>().Map(f => f.ToString());

        [MethodImpl(Inline)]
        public static string Header<F>(char delimiter)
            where F : unmanaged, Enum
        {
            var service = Formatter<F>();
            var cols = Fields<F>();
            var labels = Headers<F>();
            for(var i=0; i<cols.Length; i++)
                service.DelimitField(cols[i], labels[i], delimiter);
            return service.Render();
        }

        /// <summary>
        /// Formates a header row using a caller-supplied label producer
        /// </summary>
        /// <param name="label">The label factory</param>
        /// <param name="delimiter">The delimiter</param>
        /// <typeparam name="F">The field type</typeparam>
        [MethodImpl(Inline)]
        public static string Header<F>(Func<int,F,string> label, char delimiter)
            where F : unmanaged, Enum
        {
            var service = Formatter<F>();
            var cols = Fields<F>();
            var labels = Headers<F>();
            for(var i=0; i<cols.Length; i++)
                service.DelimitField(cols[i], label(i, cols[i]), delimiter);
            return service.Render();
        }


        [MethodImpl(Inline)]
        public static ushort Width2<E>(E spec)
            where E : unmanaged, Enum
        {
            var data = Enums.numeric<E,uint>(spec);
            (var hi, var lo) = Bits.split(data,n2);
            var seq = lo;
            
            var emit = !Bits.testbit(hi, 15);
            var w = Bits.disable(hi, 15);
            return w;
                
        }

        [MethodImpl(Inline)]
        public static short Width<E>(E spec)
            where E : unmanaged, Enum
                => (short)(Enums.numeric<E,int>(spec) >> 16);

        [MethodImpl(Inline)]
        public static short Index<E>(E spec)
            where E : unmanaged, Enum
                => (short)Enums.numeric<E,int>(spec);

        public static ParallelQuery<string> Render<R>(R[] src, Func<R,string> formatter)
            where R : IRecord
                => from r in src.AsParallel()
                   let f = formatter(r)
                   orderby r.Sequence
                   select f;
        public static R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatter, char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : IRecord
        {
            using var writer = dst.Writer();            
            writer.WriteLine(Header<F>(delimiter)); 
            
            var rendered = Render(src,formatter).ToArray();

            for(var i=0; i< rendered.Length; i++)
                writer.WriteLine(rendered[i]);   

            return src;         
        }            

        public static R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatRecord, Func<int,F,string> formatLabel,  char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : IRecord
        {
            using var writer = dst.Writer();            
            writer.WriteLine(Header<F>(formatLabel, delimiter)); 
            
            var rendered = Render(src,formatRecord).ToArray();

            for(var i=0; i< rendered.Length; i++)
                writer.WriteLine(rendered[i]);   

            return src;         
        }            

        public static Option<FilePath> Save<F,R>(R[] src, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
                => Save<F,R>(src, TabularFormats.derive<R>(), dst, mode);

        public static Option<FilePath> Save<F,R>(R[] data, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
        {                
            if(data == null || data.Length == 0)
                return Option.none<FilePath>();

            try
            {
                dst.FolderPath.Create();                            
                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = format.EmitHeader && (overwrite || !dst.Exists);                
                
                using var writer = dst.Writer(mode);

                if(emitHeader)
                    writer.WriteLine(Header<F>(format.Delimiter));

                Control.iter(data, r => writer.WriteLine(r.DelimitedText(format.Delimiter)));   
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