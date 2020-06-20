//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   

    public readonly struct RecordHeader
    {
        [MethodImpl(Inline)]
        public static string format<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => TabularFormats.derive<F>(delimiter).FormatHeader();

        [MethodImpl(Inline)]
        public static RecordHeader<F> define<F>()
            where F : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public static F[] fields<F>()
            where F : unmanaged, Enum
                => define<F>().Fields; 

        [MethodImpl(Inline)]
        public static string[] labels<F>()
            where F : unmanaged, Enum
                => define<F>().Labels;

        [MethodImpl(Inline)]
        public static string render<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => define<F>().Render(delimiter);

        /// <summary>
        /// Formates a header row using a caller-supplied label producer
        /// </summary>
        /// <param name="f">The label factory</param>
        /// <param name="delimiter">The delimiter</param>
        /// <typeparam name="F">The field type</typeparam>
        [MethodImpl(Inline)]
        public static string render<F>(Func<int,F,string> f, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => define<F>().Render(f,delimiter);
    }
}