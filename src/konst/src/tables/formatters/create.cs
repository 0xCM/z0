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

    partial struct TableFormat
    {
        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(in LiteralFields<F> fields, StringBuilder dst, char delimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(dst, delimiter, fields);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(F f = default)
            where F : unmanaged, Enum
                => new TableFormatter<F>(text.build(), FieldDelimiter, Literals.fields<F>());

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(in LiteralFields<F> fields, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(text.build(), delimiter, fields);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter, F f = default)
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(), delimiter);

        /// <summary>
        /// Creates a create from a rendering function render:C -> T
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to format</typeparam>
        [MethodImpl(Inline)]
        public static CellFormatter<C,T> formatter<C,T>(CellFormatter.RenderFunction<C,T> render)
            where C : struct
                => new CellFormatter<C,T>(render);
    }
}