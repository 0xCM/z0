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
    public readonly struct CliToken : ITextual, IEquatable<CliToken>, INullity
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
        public static CliToken from(Type src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static CliToken from<T>()
            => new CliToken(typeof(T));

        [MethodImpl(Inline)]
        public static CliToken from(FieldInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static CliToken from(PropertyInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static CliToken from(MethodInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static CliToken from(ParameterInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static CliToken from(Assembly src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        internal CliToken(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal CliToken(int token)
            => Data = (uint)token;

        [MethodImpl(Inline)]
        internal CliToken(uint token)
            => Data = token;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(CliToken src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is CliToken t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(int src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(uint src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static bool operator ==(CliToken x, CliToken y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(CliToken x, CliToken y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(Type src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(FieldInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(PropertyInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(MethodInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(ParameterInfo src)
            => new CliToken(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(CliToken src)
            => src.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(CliToken src)
            => (int)src.Data;

        public static CliToken Empty
            => default;
    }
}