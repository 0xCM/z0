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
    using static z;

    public readonly struct Tabular
    {
        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        public const ushort PosMask = 0xFFFF;

        [MethodImpl(Inline)]
        public static F[] literals<F>()
            where F : unmanaged, Enum
                => Z0.Table.index<F>().Literals;

        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static TableFormatSpec<F> Specify<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var literals = @readonly(literals<F>());
            var count = literals.Length;
            var headBuffer = sys.alloc<string>(count);
            var fieldBuffer = sys.alloc<TabularField<F>>(count);
            var fields = span(fieldBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                seek(fields,i) = new TabularField<F>(literal, literal.ToString(), (int)i, (short)(uint32(literal) >> WidthOffset));
            }

            return new TableFormatSpec<F>(fieldBuffer);
        }

        /// <summary>
        /// Computes the field index from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int Index<F>(F field)
            where F : unmanaged, Enum
                => Datasets.index(field);

        /// <summary>
        /// Computes the field width from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int Width<F>(F field)
            where F : unmanaged, Enum
                => Datasets.width(field);

        [MethodImpl(Inline)]
        public static string[] Headers<F>()
            where F : unmanaged, Enum
                => Datasets.headers<F>();

        [MethodImpl(Inline)]
        public static DatasetHeader<F> Header<F>()
            where F : unmanaged, Enum
                => new DatasetHeader<F>();

        [MethodImpl(Inline)]
        public static string HeaderText<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => Header<F>().Render(delimiter);
    }
}