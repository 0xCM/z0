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

    [ApiDataType(ApiNames.ClrField, true)]
    public readonly struct ClrField
    {
        [MethodImpl(Inline)]
        public static ClrField from(FieldInfo src)
            => new ClrField(src);

        public FieldInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrField(FieldInfo src)
            => Definition = src;

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
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
        public static bool operator ==(ClrField lhs, ClrField rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrField lhs, ClrField rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrField src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrField(FieldInfo src)
            => from(src);
    }
}