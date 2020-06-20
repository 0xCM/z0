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

    public readonly struct Records
    {
        /// <summary>
        /// Creates a record formatter predicated on a field definition set defined by an enum
        /// </summary>
        /// <param name="sep">The default field delimiter</param>
        /// <typeparam name="F">The type of the defining enum</typeparam>
        [MethodImpl(Inline)]
        public static IRecordFormatter<F> formatter<F>(char sep)
            where F : unmanaged, Enum
                => new RecordFormatter<F>(new StringBuilder(), sep);

        /// <summary>
        /// Creates a record formatter predicated on a field definition set defined by an enum
        /// </summary>
        /// <typeparam name="F">The type of the defining enum</typeparam>
        [MethodImpl(Inline)]
        public static IRecordFormatter<F> formatter<F>()
            where F : unmanaged, Enum
                => Records.Formatter<F>();

        [MethodImpl(Inline)]
        public static F[] fields<F>()
            where F : unmanaged, Enum
                => RecordHeader.fields<F>();

        [MethodImpl(Inline)]
        public static string[] labels<F>()
            where F : unmanaged, Enum
                => RecordHeader.labels<F>();

        [MethodImpl(Inline)]
        public static string header<F>(char delimiter)
            where F : unmanaged, Enum                
                => RecordHeader.render<F>(delimiter);
        public static RecordWriter Writer
        {
            [MethodImpl(Inline)]
            get => RecordWriter.Service;
        }

        [MethodImpl(Inline)]
        public static RecordFields<F> Fields<F>()
            where F : unmanaged, Enum
                => RecordFields.Create<F>();

        [MethodImpl(Inline)]
        public static RecordHeader<F> Header<F>()
            where F : unmanaged, Enum
                => RecordHeader.define<F>();

        /// <summary>
        /// Creates a record formatter predicated on an enum that specifies the record fields
        /// </summary>
        /// <typeparam name="F">The field specification type</typeparam>
        [MethodImpl(Inline)]
        public static IRecordFormatter<F> Formatter<F>()
            where F :unmanaged, Enum
                => new RecordFormatter<F>(text.build());        

        /// <summary>
        /// Creates a record formatter predicated on a field definition set defined by an enum
        /// </summary>
        /// <param name="sep">The default field delimiter</param>
        /// <typeparam name="F">The type of the defining enum</typeparam>
        [MethodImpl(Inline)]
        public static IRecordFormatter<F> Formatter<F>(char sep)
            where F : unmanaged, Enum
                => new RecordFormatter<F>(text.build(), sep);
    }
}