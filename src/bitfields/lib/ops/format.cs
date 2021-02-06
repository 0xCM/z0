//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class BitFields
    {
        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
                => format<E,T>(src, typeof(E).Name, zpad);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, string name, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            var data = EnumValue.scalar<E,T>(src);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormatter.limited(limit,zpad);
            return text.concat(name, Chars.Colon, formatter.Format(data,config));
        }

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, Base10 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = EnumValue.scalar<E,T>(src);
            return text.concat(name, Chars.Colon, Numeric.format(data, @base));
        }

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, Base16 @base, string name )
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = EnumValue.scalar<E,T>(src);
            return text.concat(name, Chars.Colon, Hex.formatter<T>().FormatItem(data));
        }

    }
}