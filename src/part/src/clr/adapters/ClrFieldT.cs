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

    public readonly struct ClrField<T> : IClrRuntimeMember<ClrField<T>,FieldInfo>
    {
        public FieldInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrField(FieldInfo src)
            => Definition = src;

        public ClrArtifactKind Kind
        {
            [MethodImpl(Inline)]
            get => ClrArtifactKind.Field;
        }

        public bool IsStatic
        {
            [MethodImpl(Inline)]
            get => Definition.IsStatic;
        }

        public ClrToken Token
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
            [MethodImpl(Inline)]
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
        public T GetValueDirect(TypedReference src)
            => memory.@as<object,T>(Definition.GetValueDirect(src));

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
        public static bool operator ==(ClrField<T> a, ClrField<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrField<T> a, ClrField<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrField<T> src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrField<T>(FieldInfo src)
            => new ClrField<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrField(ClrField<T> src)
            => new ClrField(src.Definition);
    }
}