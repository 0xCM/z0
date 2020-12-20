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

    using static Part;

    /// <summary>
    /// Represents a parametrically-identified clr enum
    /// </summary>
    public readonly struct ClrEnum<T>
        where T : unmanaged, Enum
    {
        public Type Definition => TD;

        public static ClrEnum<T> create()
            => default;

        public CliKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrEnum Untyped
        {
            [MethodImpl(Inline)]
            get => new ClrEnum(Definition);
        }

        public ReadOnlySpan<T> Literals
        {
            [MethodImpl(Inline)]
            get => _Literals;
        }

        public TypeName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrEnum(ClrEnum<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum<T> src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<T>(ClrEnum<T> src)
            => default;

        static readonly Type TD = typeof(T);

        static readonly EnumLiteralDetails<T> _Details = Data();

        static T[] _Literals = LiteralValues();

        static EnumLiteralDetails<T> Data()
        {
            var type = Enums.@base<T>();
            var fields = typeof(T).LiteralFields().ToArray();
            var indices = new List<EnumLiteralDetail<T>>(fields.Length);
            for(var i=0u; i< fields.Length; i++)
            {
                var field = fields[i];
                var value = (T)field.GetRawConstantValue();
                indices.Add(new EnumLiteralDetail<T>(field, type, i, field.Name, value, string.Empty));
            }
            return indices.ToIndex();
        }

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        static T[] LiteralValues()
        {
            var i = _Details;
            var dst = new T[i.Length];
            for(var j = 0; j<dst.Length; j++)
                dst[j] = i[j].LiteralValue;
            return dst;
        }
    }
}