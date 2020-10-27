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

    [ApiDataType(ApiNames.ClrMember, true)]
    public readonly struct ClrMember : IClrMember<ClrMember, MemberInfo>
    {
        [MethodImpl(Inline)]
        public static ClrMember from(MemberInfo src)
            => new ClrMember(src);

        public MemberInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrMember(MemberInfo src)
            => Definition = src;

        public ClrArtifactKey Id
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
        public string Format()
            => Definition.Name;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator ==(ClrMember a, ClrMember b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrMember a, ClrMember b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator MemberInfo(ClrMember src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrMember(FieldInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMember(MethodInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMember(PropertyInfo src)
            => from(src);
    }
}