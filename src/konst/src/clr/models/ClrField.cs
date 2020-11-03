//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = System.Reflection;

    [ApiDataType(ApiNames.ClrField, true)]
    public readonly struct ClrField : IClrRuntimeMember<ClrField,FieldInfo>
    {
        [MethodImpl(Inline)]
        public static ClrField from(FieldInfo src)
            => new ClrField(src);

        public FieldInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrField(FieldInfo src)
            => Definition = src;

        public ClrArtifactKey ClrKey
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrMemberName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public ClrType FieldType
        {
            get => Definition.FieldType;
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

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Definition.FieldHandle.Value;
        }

        public bool IsStatic
        {
            [MethodImpl(Inline)]
            get => Definition.IsStatic;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Definition.Name;

        [Ignore]
        FieldInfo IClrRuntimeObject<FieldInfo>.Definition
            => Definition;

        [Ignore]
        ClrArtifactKind IClrRuntimeObject.ClrKind
            => ClrArtifactKind.Field;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator ==(ClrField a, ClrField b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrField a, ClrField b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrField src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrField(FieldInfo src)
            => from(src);
    }
}