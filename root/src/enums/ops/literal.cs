//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;

    using static Root;

    public static partial class Enums
    {
        /// <summary>
        /// Reads a generic enum member from a generic value
        /// </summary>
        /// <param name="v">The value to reinterpret</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe E literal<E,V>(V v)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<E>((E*)&v);

        /// <summary>
        /// Gets the declaration-order indices for each named literal
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static EnumLiterals<E> literals<E>(bool peek = false)
            where E : unmanaged, Enum
                => peek ? CreateLiteralIndex<E>() : (EnumLiterals<E>)IndicesCache.GetOrAdd(typeof(E), _ => CreateLiteralIndex<E>());

        static EnumLiterals<E> CreateLiteralIndex<E>()
            where E : unmanaged, Enum
        {
            var fields = typeof(E).LiteralFields().ToArray();
            var indices = list<EnumLiteral<E>>(fields.Length);
            for(var i=0; i< fields.Length; i++)
            {
                var field = fields[i];
                var value = (E)field.GetRawConstantValue();
                indices.Add((i, field.Name, value));
            }
            return indices.ToIndex();
        }

        static ConcurrentDictionary<Type,object> LiteralCache {get;}
            = new ConcurrentDictionary<Type, object>();
    }
}