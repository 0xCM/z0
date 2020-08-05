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

    public readonly struct Dataset
    {
        public void Publish<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IDataModel
            where R : IRecord
            where F : unmanaged, Enum
        {
            var dst = Publications.Default.DatasetPath(model.Name);
            var header = Tabular.Header<F>();
            using var writer = dst.Writer();
            writer.WriteLine(header.Render(delimiter));
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(src[i].DelimitedText(delimiter));                
        }        
        
        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        const ushort PosMask = 0xFFFF;

        [MethodImpl(Inline)]
        public static DatasetHeader<F> header<F>()
            where F : unmanaged, Enum
                => default;        

        [MethodImpl(Inline)]
        public static string[] labels<F>()
            where F : unmanaged, Enum
                => DataFields.labels<F>();    

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
        /// Computes the field index from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int index<F>(F field)
            where F : unmanaged, Enum
                => (int)(Tabular.PosMask & Enums.e32u(field));

        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> formatter<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);

        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> formatter<F>(StringBuilder state, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(state,delimiter);                

        internal static string Render(ITextual src)
            => src?.Format() ?? string.Empty;
     
        internal static string render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return Render(t);
            else
                return content.ToString();
        }    
    }
}