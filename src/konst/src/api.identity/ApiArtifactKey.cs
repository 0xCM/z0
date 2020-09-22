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
    public readonly struct ApiArtifactKey : ITextual, IEquatable<ApiArtifactKey>, INullity
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
        public static ApiArtifactKey from(Type src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static ApiArtifactKey from<T>()
            => new ApiArtifactKey(typeof(T));

        [MethodImpl(Inline)]
        public static ApiArtifactKey from(FieldInfo src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static ApiArtifactKey from(PropertyInfo src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static ApiArtifactKey from(MethodInfo src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static ApiArtifactKey from(ParameterInfo src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static ApiArtifactKey from(Assembly src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(int src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(uint src)
            => new ApiArtifactKey(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ApiArtifactKey x, ApiArtifactKey y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ApiArtifactKey x, ApiArtifactKey y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(Type src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(FieldInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(PropertyInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(MethodInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(ParameterInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(ApiArtifactKey src)
            => (uint)src.Data.Location;

        [MethodImpl(Inline)]
        public static explicit operator int(ApiArtifactKey src)
            => (int)src.Data.Location;

        [MethodImpl(Inline)]
        internal ApiArtifactKey(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(int token)
        {
            Data = (uint)token;
        }

        [MethodImpl(Inline)]
        internal ApiArtifactKey(uint token)
        {
            Data = token;
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiArtifactKey src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is ApiArtifactKey t && Equals(t);

        public static ApiArtifactKey Empty
            => default;
    }
}