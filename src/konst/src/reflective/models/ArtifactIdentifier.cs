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

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(int src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(uint src)
            => new ArtifactIdentifier(src);

        public int TokenValue
        {
            [MethodImpl(Inline)]
            get => (int)Data.Location;
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
            => Data.Format();

        [MethodImpl(Inline)]
        public static ArtifactIdentifier From(Type src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier From<T>()
            => new ArtifactIdentifier(typeof(T));

        [MethodImpl(Inline)]
        public static ArtifactIdentifier From(FieldInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier From(PropertyInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier From(MethodInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentifier From(ParameterInfo src)
            => new ArtifactIdentifier(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ArtifactIdentifier x, ArtifactIdentifier y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ArtifactIdentifier x, ArtifactIdentifier y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(Type src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(FieldInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(PropertyInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(MethodInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentifier(ParameterInfo src)
            => From(src);

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