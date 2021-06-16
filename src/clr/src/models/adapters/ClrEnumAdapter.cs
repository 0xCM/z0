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
    using System.Reflection;

    using static Root;

    using NK = NumericKind;
    using BK = ClrEnumKind;

    public readonly struct ClrEnumAdapter
    {
        /// <summary>
        /// Determines the integral type refined by a parametrically-identified enum type
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        public static ClrEnumKind @base<E>()
            where E : unmanaged, Enum
             => @base(typeof(E).GetEnumUnderlyingType().NumericKind());

        /// <summary>
        /// Determines the integral type refined by a value-identified enum type
        /// </summary>
        /// <param name="value">The enum value</typeparam>
        [Op]
        public static ClrEnumKind @base(Enum value)
            => @base(value.GetType().GetEnumUnderlyingType().NumericKind());

        /// <summary>
        /// Determines the integral type refined by a specified enum type
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [Op]
        public static ClrEnumKind @base(Type et)
            => @base(et.NumericKind());

        [Op]
        public static ClrEnumKind @base(NumericKind src)
             => src switch{
                NK.U8 => BK.U8,
                NK.I8 => BK.I8,
                NK.U16 => BK.U16,
                NK.I16 => BK.I16,
                NK.U32 => BK.U32,
                NK.I32 => BK.I32,
                NK.I64 => BK.I64,
                NK.U64 => BK.U64,
                _ => ClrEnumKind.None,
            };

        [MethodImpl(Inline)]
        public static ClrEnumFieldAdapter<E> field<E>(uint index, FieldInfo src, E value)
            where E : unmanaged, Enum
                => new ClrEnumFieldAdapter<E>(index,src,value);

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