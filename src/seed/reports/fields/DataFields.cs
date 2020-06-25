//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   
    using static Root;
    
    public readonly struct DataFields
    {
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