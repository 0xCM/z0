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

    public readonly struct Tabular
    {
        /// <summary>
        /// Defines the bit position where the field width specification begins
        /// </summary>
        public const int WidthOffset = 16;

        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        public const ushort PosMask = 0xFFFF;

        /// <summary>
        /// The default field delimiter
        /// </summary>
        public const char DefaultDelimiter = Chars.Pipe;

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
        public static FieldFormatter<F> formatter<F>(char? delimiter = null) 
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
        public static string header<F>(char delimiter = DefaultDelimiter)
            where F : unmanaged, Enum
        {
            var service = formatter<F>(delimiter);
            var cols = fields<F>();
            var labels = headers<F>();
            for(var i=0; i<cols.Length; i++)
                service.Delimit(cols[i], labels[i]);
            return service.Format();
        }

        public static void Save<F,T>(T[] src, FilePath dst, char delimiter = DefaultDelimiter)
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