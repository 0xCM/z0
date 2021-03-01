//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Enums
    {
        public static EnumLiteralDetails<E> details<E>()
            where E : unmanaged, Enum
        {
            var type = ClrEnums.@base<E>();
            var fields = @readonly(typeof(E).LiteralFields());
            var count = fields.Length;
            var buffer = alloc<EnumLiteralDetail<E>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields, i);
                seek(dst,i) = new EnumLiteralDetail<E>(field, type, i, field.Name, (E)field.GetRawConstantValue());
            }
            return buffer;
        }

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        public static EnumLiteralDetails<E,T> details<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var src = details<E>();
            var count = src.Length;
            var buffer = new EnumLiteralDetail<E,T>[count];
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var literal = ref src[i];
                seek(dst,i) = evalue(literal, EnumValue.scalar<E,T>(literal.LiteralValue));
            }
            return buffer;
        }
    }
}