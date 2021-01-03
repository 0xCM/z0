//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Identifies an <see cref='Enum'/>
    /// </summary>
    public readonly struct EnumIdentity : IIdentifiedType<EnumIdentity>
    {
        public string Identifier {get;}

        public string Name {get;}

        public NumericKind BaseType {get;}

        [MethodImpl(Inline)]
        public static EnumIdentity define(Type src)
            => src.IsEnum ? new EnumIdentity(src.Name, src.GetEnumUnderlyingType().NumericKind()) : Empty;

        [MethodImpl(Inline)]
        public EnumIdentity(string name, NumericKind basetype)
        {
            Name = name;
            BaseType = basetype;
            Identifier = basetype != 0 ? $"{Name}{IDI.ModSep}{basetype.Format()}" : string.Empty;
        }

        IIdentifiedType<EnumIdentity> Identified => this;

        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.define(Identifier);

        [MethodImpl(Inline)]
        public static implicit operator string(EnumIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(EnumIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(EnumIdentity a, EnumIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(EnumIdentity a, EnumIdentity b)
            => !a.Equals(b);

        public static EnumIdentity Empty = new EnumIdentity(EmptyString, NumericKind.None);

    }
}