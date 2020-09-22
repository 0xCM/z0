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
    public readonly struct ClrMemberIdentity : ITextual, IEquatable<ClrMemberIdentity>, INullity
    {
        readonly ulong Data;

        public ClrArtifactKey OwnerId
        {
            [MethodImpl(Inline)]
            get => (uint)(Data >> 32);
        }

        public ClrArtifactKey MemberId
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
        public static ClrMemberIdentity From(FieldInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline)]
        public static ClrMemberIdentity From(PropertyInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline)]
        public static ClrMemberIdentity From(MethodInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ClrMemberIdentity x, ClrMemberIdentity y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrMemberIdentity x, ClrMemberIdentity y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberIdentity(FieldInfo src)
            => Reflex.identity(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberIdentity(PropertyInfo src)
            => Reflex.identity(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberIdentity(MethodInfo src)
            => From(src);

        [MethodImpl(Inline)]
        internal ClrMemberIdentity(FieldInfo src)
            : this(src.DeclaringType.MetadataToken, src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrMemberIdentity(PropertyInfo src)
            : this(src.DeclaringType.MetadataToken, src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrMemberIdentity(MethodInfo src)
            : this(src.DeclaringType.MetadataToken, src.MetadataToken)
        {

        }

        ClrMemberIdentity(uint owner, uint member)
        {
            Data = ((ulong)owner << 32) | (ulong)member;

        }

        [MethodImpl(Inline)]
        internal ClrMemberIdentity(int owner, int member)
            : this((uint)owner, (uint)member)
        {

        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ClrMemberIdentity src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is ClrMemberIdentity t && Equals(t);

        public static ClrMemberIdentity Empty
            => default;
    }
}