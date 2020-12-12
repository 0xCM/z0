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
    public readonly struct CliArtifactKey : ITextual, IEquatable<CliArtifactKey>, INullity
    {
        readonly uint Data;

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
            => Data.FormatHex();

        [MethodImpl(Inline)]
        public static CliArtifactKey from(Type src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static CliArtifactKey from<T>()
            => new CliArtifactKey(typeof(T));

        [MethodImpl(Inline)]
        public static CliArtifactKey from(FieldInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static CliArtifactKey from(PropertyInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static CliArtifactKey from(MethodInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static CliArtifactKey from(ParameterInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static CliArtifactKey from(Assembly src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        internal CliArtifactKey(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliArtifactKey(int token)
            => Data = (uint)token;

        [MethodImpl(Inline)]
        internal CliArtifactKey(uint token)
            => Data = token;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(CliArtifactKey src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is CliArtifactKey t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(int src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(uint src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static bool operator ==(CliArtifactKey x, CliArtifactKey y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(CliArtifactKey x, CliArtifactKey y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(Type src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(FieldInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(PropertyInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(MethodInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKey(ParameterInfo src)
            => new CliArtifactKey(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(CliArtifactKey src)
            => src.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(CliArtifactKey src)
            => (int)src.Data;

        public static CliArtifactKey Empty
            => default;
    }
}