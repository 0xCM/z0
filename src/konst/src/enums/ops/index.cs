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
        public static EnumLiterals index(Assembly src)
        {
            var enums = src.GetTypes().Where(t => t.IsEnum);
            var dst = EnumLiterals.Empty;
            for(var i=0; i<enums.Length; i++)
            {
                dst = dst.Append(index(enums[i]));
            }
            return dst;
        }
        
        [MethodImpl(Inline), Op]
        public static EnumLiterals index(Type @enum)
        {
            var ut = @enum.GetEnumUnderlyingType();
            var nk = ut.NumericKind();
            var ek = Enums.@base(nk);
            var type = Enums.@base(@enum);
            var fields = span(@enum.LiteralFields());
            var count = fields.Length;
            var buffer = sys.alloc<EnumLiteral>(count);
            var dst = span(buffer);
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var scalar = Variant.define(field.GetRawConstantValue(), nk);
                seek(dst,i) = new EnumLiteral(field, ek, i, field.Name, scalar);
            }

            return new EnumLiterals(buffer);
        }

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