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

    public readonly struct BitFieldFormatter
    {
        [Op, Closures(UnsignedInts)]
        public static string format<T>(ReadOnlySpan<BitFieldSegment<T>> src)
            where T : unmanaged
                => BitFieldSpecs.format<BitFieldSegment<T>,T>(src);

        [MethodImpl(Inline)]
        public static string format<F>(F entry)
            where F : unmanaged, IBitFieldIndexEntry<F>
                => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";

        public static string format<W>(in BitFieldIndexEntry<W> src)
            where W : unmanaged, Enum
                => $"{src.FieldWidth.GetType().Name}[{src.FieldIndex}] = {src.FieldName}";

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="V">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<V,T>(V value)
            where V : unmanaged, Enum
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            var data = Enums.scalar<V,T>(value);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormatter.limited(limit);
            var name = typeof(V).Name;
            var bits = formatter.Format(data,config);
            return text.concat(name, Chars.Colon, bits);
        }
    }
}