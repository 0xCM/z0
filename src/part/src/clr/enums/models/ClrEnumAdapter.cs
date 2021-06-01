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

    using static Part;

    public readonly struct ClrEnumAdapter
    {
        public Type Definition {get;}

        [MethodImpl(Inline)]
        public ClrEnumAdapter(Type src)
            => Definition = src;

        public CliToken Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrTypeName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public ClrStructAdapter RefinedType
        {
            [MethodImpl(Inline)]
            get => new ClrStructAdapter(Definition.GetEnumUnderlyingType());
        }

        [MethodImpl(Inline)]
        public string Format()
            => Definition.FullName;

        [MethodImpl(Inline)]
        public bool Equals(ClrEnumAdapter src)
            => Definition.Equals(src.Definition);

        public override string ToString()
            => Format();

        static EnumLiteralDetails<E> Data<E>()
            where E : unmanaged, Enum
        {
            var type = Enums.@base<E>();
            var fields = typeof(E).LiteralFields().ToArray();
            var indices = new List<EnumLiteralDetail<E>>(fields.Length);
            for(var i=0u; i< fields.Length; i++)
            {
                var field = fields[i];
                var value = (E)field.GetRawConstantValue();
                indices.Add(new EnumLiteralDetail<E>(field, type, i, field.Name, value));
            }
            return indices.ToArray();
        }

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        public static E[] Literals<E>()
            where E : unmanaged, Enum
        {
            var i = Data<E>();
            var dst = new E[i.Length];
            for(var j = 0; j<dst.Length; j++)
                dst[j] = i[j].LiteralValue;
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrTypeAdapter(ClrEnumAdapter src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnumAdapter src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrEnumAdapter(Type src)
            => new ClrEnumAdapter(src);
    }
}