//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    [ApiDataType(ApiNames.ClrEnum, true)]
    public readonly struct ClrEnum
    {
        public Type Definition {get;}

        [MethodImpl(Inline)]
        public static ClrEnum from(Type src)
            => new ClrEnum(src);

        [MethodImpl(Inline)]
        public ClrEnum(Type src)
            => Definition = src;

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrTypeName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public ClrStruct BaseType
        {
            [MethodImpl(Inline)]
            get => new ClrStruct(Definition.GetEnumUnderlyingType());
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrEnum src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrEnum(Type src)
            => new ClrEnum(src);

        [MethodImpl(Inline)]
        public string Format()
            => Definition.FullName;

        [MethodImpl(Inline)]
        public bool Equals(ClrEnum src)
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
                indices.Add(new EnumLiteralDetail<E>(field, type, i, field.Name, value, string.Empty, UserMetadata.Empty));
            }
            return indices.ToIndex();
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
    }
}