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
    public readonly struct CliKey : ITextual, IEquatable<CliKey>, INullity
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
        public static CliKey from(Type src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static CliKey from<T>()
            => new CliKey(typeof(T));

        [MethodImpl(Inline)]
        public static CliKey from(FieldInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static CliKey from(PropertyInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static CliKey from(MethodInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static CliKey from(ParameterInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static CliKey from(Assembly src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        internal CliKey(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliKey(int token)
            => Data = (uint)token;

        [MethodImpl(Inline)]
        internal CliKey(uint token)
            => Data = token;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(CliKey src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is CliKey t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(int src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(uint src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static bool operator ==(CliKey x, CliKey y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(CliKey x, CliKey y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(Type src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(FieldInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(PropertyInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(MethodInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static implicit operator CliKey(ParameterInfo src)
            => new CliKey(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(CliKey src)
            => src.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(CliKey src)
            => (int)src.Data;

        public static CliKey Empty
            => default;
    }
}