//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using static Konst;   
    using static z;
    
    public readonly struct DataFields
    {
        public static void append<F>(StringBuilder dst, F f, object content)   
            where F : unmanaged, Enum
        {
            dst.Append(render(dst, content).PadRight(width(f)));
        }

        public static void Delimit<F>(StringBuilder dst, F f, object content, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {            
            dst.Append(text.rspace(delimiter));            
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

        [MethodImpl(Inline)]
        public static DataFields<F> define<F>()
            where F : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public static DatasetHeader<F> header<F>()
            where F : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public static F[] literals<F>()
            where F : unmanaged, Enum            
                => define<F>().Literals;

        [MethodImpl(Inline)]
        public static string[] labels<F>()
            where F : unmanaged, Enum
                => define<F>().Labels;

        [MethodImpl(Inline)]
        public static short width<F>(F f)
            where F : unmanaged, Enum
                => define<F>().Width(f);

        [MethodImpl(Inline)]
        public static short index<F>(F f)
            where F : unmanaged, Enum
                => define<F>().Index(f);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter = FieldDelimiter) 
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(), delimiter);        
    }
}