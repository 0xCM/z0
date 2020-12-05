//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static EnumFieldValues<E,T> index<E,T>(EnumFieldValue<E,T>[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumFieldValues<E,T>(src);

        /// <summary>
        /// Gets the declaration-order indices for each named literal
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static EnumLiteralDetails<E> index<E>()
            where E : unmanaged, Enum
                => (EnumLiteralDetails<E>)IndexCache.GetOrAdd(typeof(E), _ => CreateIndex<E>());

        static EnumLiteralDetails<E> CreateIndex<E>()
            where E : unmanaged, Enum
        {
            var type = Enums.@base<E>();
            var fields = typeof(E).LiteralFields().ToArray();
            var indices = new List<EnumLiteralDetail<E>>(fields.Length);
            for(var i=0u; i< fields.Length; i++)
            {
                var field = fields[i];
                var value = (E)field.GetRawConstantValue();
                indices.Add(new EnumLiteralDetail<E>(field, type, i, field.Name, value, string.Empty));
            }
            return indices.ToIndex();
        }
    }
}