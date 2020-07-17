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

    using static Konst;

    partial class Enums
    {
        static ConcurrentDictionary<Type,object> IndexCache {get;}
            = new ConcurrentDictionary<Type,object>();

        static ConcurrentDictionary<Type,object> LiteralCache {get;}
            = new ConcurrentDictionary<Type, object>();        

        static ConcurrentDictionary<Type,object> ValueCache {get;}
            = new ConcurrentDictionary<Type,object>();

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


        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        public static EnumLiterals<E,T> LiteralSequence<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = CreateIndex<E>();
            var dst = new EnumLiteral<E,T>[index.Length];
            for(var i=0; i<index.Length; i++)
            {
                var literal = index[i];
                dst[i] =  evalue(literal, scalar<E,T>(literal.LiteralValue));
            }
            return dst;        
        }


        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        static E[] CreateLiteralArray<E>()
            where E : unmanaged, Enum
        {
            var i = index<E>();
            var dst = new E[i.Length];
            for(var j = 0; j<dst.Length; j++)
                dst[j] = i[j].LiteralValue;
            return dst;    
        }
    }
}