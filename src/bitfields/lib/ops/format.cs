//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitFields
    {
        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            var data = Enums.scalar<E,T>(src);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormatter.limited(limit);
            var name = typeof(E).Name;
            var bits = formatter.Format(data,config);
            return text.concat(name, Chars.Colon, bits);
        }

    }
}