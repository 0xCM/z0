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
    public readonly struct HexFormats
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static HexDataFormatter data(MemoryAddress? @base = null, ushort bpl = 20, bool labels = true)
            => new HexDataFormatter(new HexLineConfig(bpl, labels), @base);

        /// <summary>
        /// Creates a <see cref='HexFormatter<T>'/> for primitive numeric types
        /// </summary>
        /// <typeparam name="T">The primitive numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.create<T>());

        /// <summary>
        /// Formats a sequence of primal numeric calls as data-formatted hex
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string array<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => HexFormats.formatter<T>().Format(src, HexFormatSpecs.HexArray);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string field<E,T>(E src, Base10 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = ClrEnums.scalar<E,T>(src);
            return text.concat(name, Chars.Colon, Numeric.format(data, @base));
        }

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string field<E,T>(E src, Base16 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
                => text.concat(name, Chars.Colon, HexFormats.formatter<T>().FormatItem(ClrEnums.scalar<E,T>(src)));
    }
}