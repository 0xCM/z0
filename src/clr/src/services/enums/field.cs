//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Enums
    {
        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string field<E,T>(E src, Base16 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
                => string.Concat(name, Chars.Colon, HexFormatter.formatter<T>().FormatItem(scalar<E,T>(src)));

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
            var data = Enums.scalar<E,T>(src);
            return string.Concat(name, Chars.Colon, NumbericFormat.format(data, @base));
        }

        [MethodImpl(Inline)]
        public static ClrEnumFieldAdapter<E> field<E>(uint index, FieldInfo src, E value)
            where E : unmanaged, Enum
                => new ClrEnumFieldAdapter<E>(index,src,value);
    }
}