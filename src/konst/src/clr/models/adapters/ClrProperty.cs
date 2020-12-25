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

    [ApiType(ApiNames.ClrProperty, true)]
    public readonly struct ClrProperty : IClrRuntimeMember<ClrProperty, PropertyInfo>
    {
        public PropertyInfo Definition {get;}

        public CliKey Token
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrMemberName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(ClrProperty lhs, ClrProperty rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrProperty lhs, ClrProperty rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator PropertyInfo(ClrProperty src)
            => src.Definition;

        [MethodImpl(Inline)]
        public ClrProperty(PropertyInfo data)
            => Definition = data;

        [MethodImpl(Inline)]
        public string Format()
            => Definition.Name;

        [Ignore]
        PropertyInfo IClrRuntimeObject<PropertyInfo>.Definition
            => Definition;

        [Ignore]
        ClrArtifactKind IClrRuntimeObject.ClrKind
            => ClrArtifactKind.Property;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();
    }
}