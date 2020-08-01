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
    using System.Reflection;


    using static Konst;
    using static z;

    partial class Enums
    {

        
        /// <summary>
        /// Gets the declaration-order indices for each named literal
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static EnumLiterals<E> index<E>()
            where E : unmanaged, Enum
                => (EnumLiterals<E>)IndexCache.GetOrAdd(typeof(E), _ => CreateIndex<E>());

        static EnumLiterals<E> CreateIndex<E>()
            where E : unmanaged, Enum
        {
            var type = Enums.@base<E>();
            var fields = typeof(E).LiteralFields().ToArray();
            var indices = new List<EnumLiteral<E>>(fields.Length);
            for(var i=0u; i< fields.Length; i++)
            {
                var field = fields[i];
                var value = (E)field.GetRawConstantValue();
                indices.Add(new EnumLiteral<E>(field, type, i, field.Name, value, string.Empty, UserMetadata.Empty));
            }
            return indices.ToIndex();
        }
    }
}