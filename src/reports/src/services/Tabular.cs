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

    public readonly struct Tabular<F,R> : ITabular<F,R>
        where F : unmanaged, Enum
        where R : ITabular
    {
        readonly R Record;

        readonly Func<R,char,string> Formatter;
    
        [MethodImpl(Inline)]
        public Tabular(R record, Func<R,char,string> formatter)
        {
            Record = record;
            Formatter = formatter;
        }
        
        public string DelimitedText(char delimiter)
            => Formatter(Record,delimiter);
    }
    
    public readonly struct Tabular
    {
        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        public const ushort PosMask = 0xFFFF;

        /// <summary>
        /// Computes the field index from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int index<F>(F field)
            where F : unmanaged, Enum
                => (int)(Tabular.PosMask & Enums.e32u(field));

        /// <summary>
        /// Computes the field width from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int width<F>(F field)
            where F : unmanaged, Enum
                => text.width(field);

        [MethodImpl(Inline)]
        public static Tabular<F,R> proxy<F,R>(R record, Func<R,char,string> formatter)
            where F : unmanaged, Enum
            where R : ITabular
                => new Tabular<F,R>(record,formatter);

        /// <summary>
        /// Defines a tabular format specifiecation predicated on a parametric enum type
        /// </summary>
        /// <typeparam name="F">The field specifier</typeparam>
        public static TabularFormat<F> format<F>()
            where F : unmanaged, Enum
        {
            var specs = Enums.valarray<F>();
            var dst = new TabularField<F>[specs.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = new TabularField<F>(specs[i]);
            return new TabularFormat<F>(dst);            
        }

        [MethodImpl(Inline)]
        public static RecordFormatter<F> record<F>()
            where F : unmanaged, Enum
                => RecordFormatter.Create<F>();

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter) 
            where F : unmanaged, Enum
                => FieldFormatter<F>.Default.Reset(delimiter);

        /// <summary>
        /// Defines a tabular field specification predicated on an enumeration literal
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static TabularField<F> field<F>(F field)
            where F : unmanaged, Enum
                => new TabularField<F>(field);        

        [MethodImpl(Inline)]
        public static F[] fields<F>()
            where F : unmanaged, Enum
                => Enums.valarray<F>();

        [MethodImpl(Inline)]
        public static string[] headers<F>()
            where F : unmanaged, Enum
                => fields<F>().Select(f => f.ToString());

        [MethodImpl(Inline)]
        public static string header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var service = formatter<F>(delimiter);
            var cols = fields<F>();
            var labels = headers<F>();
            for(var i=0; i<cols.Length; i++)
                service.Delimit(cols[i], labels[i]);
            return service.Format();
        }

        public static void Save<F,T>(T[] src, FilePath dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where T : ITabular
        {
            var formatted = new string[src.Length];            
            for(var i=0; i<src.Length; i++)
                formatted[i] = src[i].DelimitedText(delimiter);

            using var writer = dst.Writer();
            writer.WriteLine(Tabular.header<F>(delimiter)); 
            writer.WriteLine(new string(Chars.Dash, formatted.Max(x => x.Length)));
            for(var i=0; i< formatted.Length; i++)
                writer.WriteLine(formatted[i]);            
        }            
    }
}