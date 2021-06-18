//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Root;

    using api = CliTokens;

    /// <summary>
    /// Identifies a metadata element
    /// </summary>
    [ApiHost]
    public readonly struct CliToken : ITextual, IEquatable<CliToken>, INullity, IComparable<CliToken>
    {
        [MethodImpl(Inline), Op]
        public static CliToken from(Handle src)
        {
            var data = CliHandleData.from(src);
            return new CliToken(data.Table, data.RowId);
        }

        [MethodImpl(Inline), Op]
        public static CliToken from(EntityHandle src)
            => core.@as<EntityHandle,CliToken>(src);

        readonly uint Data;

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
        public CliToken(int token)
            => Data = (uint)token;

        [MethodImpl(Inline)]
        public CliToken(uint token)
            => Data = token;

        [MethodImpl(Inline)]
        public CliToken(CliTableKind table, uint row)
        {
            Data = (uint)table << 24 | (row & 0xFFFFFF);
        }

        public CliTableKind Table
        {
            [MethodImpl(Inline)]
            get => (CliTableKind)(Data >> 24);
        }

        public uint Row
        {
            [MethodImpl(Inline)]
            get => Data & 0xFFFFFF;
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

        [MethodImpl(Inline)]
        public string Format()
            => IsEmpty ? EmptyString : string.Format("{0:X2}:{1:x6}", (byte)Table, Row);


        [MethodImpl(Inline)]
        public int CompareTo(CliToken src)
            => Data.CompareTo(src.Data);

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

        [MethodImpl(Inline)]
        public static implicit operator CliToken(Handle src)
            => api.token(src);

        [MethodImpl(Inline)]
        public static implicit operator CliToken(EntityHandle src)
            => api.token(src);

        public static CliToken Empty
            => default;
    }
}