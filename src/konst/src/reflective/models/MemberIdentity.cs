//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies a metadata element
    /// </summary>
    public readonly struct MemberIdentity : ITextual, IEquatable<MemberIdentity>, INullity
    {
        readonly ulong Data;

        public ArtifactIdentity OwnerId
        {
            [MethodImpl(Inline)]
            get => (uint)(Data >> 32);
        }

        public ArtifactIdentity MemberId
        {
            [MethodImpl(Inline)]
            get => (uint)(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }
        public string Format()
            => text.format("{0}:{1}", OwnerId, MemberId);


        [MethodImpl(Inline)]
        public static MemberIdentity From(FieldInfo src)
            => new MemberIdentity(src);

        [MethodImpl(Inline)]
        public static MemberIdentity From(PropertyInfo src)
            => new MemberIdentity(src);

        [MethodImpl(Inline)]
        public static MemberIdentity From(MethodInfo src)
            => new MemberIdentity(src);

        [MethodImpl(Inline)]
        public static bool operator ==(MemberIdentity x, MemberIdentity y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(MemberIdentity x, MemberIdentity y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator MemberIdentity(FieldInfo src)
            => Reflex.identity(src);

        [MethodImpl(Inline)]
        public static implicit operator MemberIdentity(PropertyInfo src)
            => Reflex.identity(src);

        [MethodImpl(Inline)]
        public static implicit operator MemberIdentity(MethodInfo src)
            => From(src);

        [MethodImpl(Inline)]
        internal MemberIdentity(FieldInfo src)
            : this(src.DeclaringType.MetadataToken, src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MemberIdentity(PropertyInfo src)
            : this(src.DeclaringType.MetadataToken, src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MemberIdentity(MethodInfo src)
            : this(src.DeclaringType.MetadataToken, src.MetadataToken)
        {

        }

        MemberIdentity(uint owner, uint member)
        {
            Data = ((ulong)owner << 32) | (ulong)member;

        }

        [MethodImpl(Inline)]
        internal MemberIdentity(int owner, int member)
            : this((uint)owner, (uint)member)
        {

        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(MemberIdentity src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is MemberIdentity t && Equals(t);

        public static MemberIdentity Empty
            => default;
    }
}