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
    public readonly struct ArtifactIdentifier : ITextual, IEquatable<ArtifactIdentifier>, INullity
    {
        readonly Address32 Data;

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

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from(Type src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from<T>()
            => new ArtifactIdentifier(typeof(T));

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from(FieldInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from(PropertyInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from(MethodInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from(ParameterInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier from(Assembly src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(int src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(uint src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ArtifactIdentifier x, ArtifactIdentifier y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ArtifactIdentifier x, ArtifactIdentifier y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(Type src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(FieldInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(PropertyInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(MethodInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(ParameterInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(ArtifactIdentifier src)
            => (uint)src.Data.Location;

        [MethodImpl(Inline)]
        public static explicit operator int(ArtifactIdentifier src)
            => (int)src.Data.Location;

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(int token)
        {
            Data = (uint)token;
        }

        [MethodImpl(Inline)]
        internal ArtifactIdentifier(uint token)
        {
            Data = token;
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ArtifactIdentifier src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is ArtifactIdentifier t && Equals(t);

        public static ArtifactIdentifier Empty
            => default;
    }
}