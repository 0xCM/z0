//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public class AsmRecords
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
                => Records.Formatter<F>();

        [MethodImpl(Inline)]
        public static F[] Fields<F>()
            where F : unmanaged, Enum
                => RecordHeader.Create<F>().Fields; 

        [MethodImpl(Inline)]
        public static string[] Headers<F>()
            where F : unmanaged, Enum
                => RecordHeader.Create<F>().Labels; 

        [MethodImpl(Inline)]
        public static string Header<F>(char delimiter)
            where F : unmanaged, Enum                
                => RecordHeader.Create<F>().Render(delimiter);

        /// <summary>
        /// Formates a header row using a caller-supplied label producer
        /// </summary>
        /// <param name="label">The label factory</param>
        /// <param name="delimiter">The delimiter</param>
        /// <typeparam name="F">The field type</typeparam>
        [MethodImpl(Inline)]
        public static string Header<F>(Func<int,F,string> label, char delimiter)
            where F : unmanaged, Enum
                => RecordHeader.Create<F>().Render(label,delimiter);

        [MethodImpl(Inline)]
        public static short Width<E>(E spec)
            where E : unmanaged, Enum
                => (short)(Control.tVal<E,int>(spec) >> 16);

        [MethodImpl(Inline)]
        public static short Index<E>(E spec)
            where E : unmanaged, Enum
                => (short)Control.tVal<E,int>(spec);

        public static R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatter, char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : IRecord
                => Records.Writer.Save<F,R>(src,dst,formatter,delimiter);

        public static R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatRecord, Func<int,F,string> formatLabel,  char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : IRecord
                => Records.Writer.Save<F,R>(src,dst,formatRecord,formatLabel,delimiter);

        public static Option<FilePath> Save<F,R>(R[] src, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
                => Save<F,R>(src, TabularFormats.derive<R>(), dst, mode);

        public static Option<FilePath> Save<F,R>(R[] data, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : IRecord
            where F : unmanaged, Enum
                => Records.Writer.Save<F,R>(data,format,dst,mode);
    }
}