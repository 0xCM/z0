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
    public readonly struct ClrToken : ITextual, IEquatable<ClrToken>, INullity
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
        public static ClrToken from(Type src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static ClrToken from<T>()
            => new ClrToken(typeof(T));

        [MethodImpl(Inline)]
        public static ClrToken from(FieldInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static ClrToken from(PropertyInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static ClrToken from(MethodInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static ClrToken from(ParameterInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static ClrToken from(Assembly src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        internal ClrToken(Type src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(Assembly src)
            : this(src.GetHashCode())
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ClrToken(int token)
            => Data = (uint)token;

        [MethodImpl(Inline)]
        internal ClrToken(uint token)
            => Data = token;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ClrToken src)
            => Data == src.Data;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is ClrToken t && Equals(t);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(int src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(uint src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ClrToken x, ClrToken y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrToken x, ClrToken y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(Type src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(FieldInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(PropertyInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(MethodInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrToken(ParameterInfo src)
            => new ClrToken(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(ClrToken src)
            => src.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(ClrToken src)
            => (int)src.Data;

        public static ClrToken Empty
            => default;
    }
}