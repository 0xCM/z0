//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    using R = System.Reflection;

    public readonly struct ClrEnumField : IClrRuntimeMember<ClrEnumField,FieldInfo>
    {
        public uint Index {get;}

        public FieldInfo Definition {get;}

        public ulong Value {get;}

        [MethodImpl(Inline)]
        public ClrEnumField(uint index, FieldInfo src, ulong value)
        {
            Index = index;
            Definition = src;
            Value = value;
        }

        public ClrArtifactKind Kind
        {
            [MethodImpl(Inline)]
            get => ClrArtifactKind.EnumField;
        }

        public ClrType RefinedType
        {
            [MethodImpl(Inline)]
            get => DeclaringType.Definition.GetEnumUnderlyingType();
        }

        public CliToken Token
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrMemberName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public R.FieldAttributes Attributes
        {
            [MethodImpl(Inline)]
            get => Definition.Attributes;
        }

        public ClrType DeclaringType
        {
            [MethodImpl(Inline)]
            get => Definition.DeclaringType;
        }

        public bool IsLiteral
        {
            [MethodImpl(Inline)]
            get => Definition.IsLiteral;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Definition.FieldHandle.Value;
        }


        [MethodImpl(Inline)]
        public string Format()
            => Definition.Name;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator ==(ClrEnumField a, ClrEnumField b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrEnumField a, ClrEnumField b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrEnumField src)
            => src.Definition;
    }
}