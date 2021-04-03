//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct Datasets
    {
        [MethodImpl(Inline)]
        public static DatasetFormatter<F> formatter<F>(char delimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);

        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        public const ushort PosMask = 0xFFFF;

        const NumericKind Closure = UnsignedInts;

        public static string header53<T>(char delimiter = FieldDelimiter)
            where T : unmanaged, Enum
                => datasetHeader<T>().Render(delimiter);

        [MethodImpl(Inline)]
        public static DatasetHeader<F> datasetHeader<F>()
            where F : unmanaged, Enum
                => new DatasetHeader<F>();

        /// <summary>
        /// Computes the field width from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int width<F>(F field)
            where F : unmanaged, Enum
                => text.width(field);

        [Op]
        internal static string render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return t.Format();
            else
                return content.ToString();
        }
    }
}