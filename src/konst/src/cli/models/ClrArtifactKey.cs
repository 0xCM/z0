//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// Identifies a metadata element
    /// </summary>
    public readonly struct ClrArtifactKey : ITextual, IEquatable<ClrArtifactKey>, INullity
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
        public static ClrArtifactKey from(Type src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static ClrArtifactKey from<T>()
            => new ClrArtifactKey(typeof(T));

        [MethodImpl(Inline)]
        public static ClrArtifactKey from(FieldInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static ClrArtifactKey from(PropertyInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static ClrArtifactKey from(MethodInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static ClrArtifactKey from(ParameterInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static ClrArtifactKey from(Assembly src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        internal ClrArtifactKey(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrArtifactKey(int token)
            => Data = (uint)token;

        [MethodImpl(Inline)]
        internal ClrArtifactKey(uint token)
            => Data = token;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ClrArtifactKey src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is ClrArtifactKey t && Equals(t);


         [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(int src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(uint src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ClrArtifactKey x, ClrArtifactKey y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrArtifactKey x, ClrArtifactKey y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(Type src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(FieldInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(PropertyInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(MethodInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactKey(ParameterInfo src)
            => new ClrArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(ClrArtifactKey src)
            => (uint)src.Data.Location;

        [MethodImpl(Inline)]
        public static explicit operator int(ClrArtifactKey src)
            => (int)src.Data.Location;

        public static ClrArtifactKey Empty
            => default;
    }
}