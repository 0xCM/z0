//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = ClrPrimitives;

    /// <summary>
    /// Defines a runtime type name
    /// </summary>
    public readonly struct ClrTypeName : IDataTypeComparable<ClrTypeName>
    {
        internal readonly Type Source;

        [MethodImpl(Inline)]
        public ClrTypeName(Type src)
            => Source = src;

        [MethodImpl(Inline), Ignore]
        public string Format()
            => Source.Name;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => api.hash(this);
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Source.Name.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Source.Name.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length * sizeof(char);
        }

        public Name ShortName
        {
            [MethodImpl(Inline)]
            get => Source.Name;
        }

        public Name FullName
        {
            [MethodImpl(Inline)]
            get => Source.FullName;
        }

        public Name AssemblyQualifiedName
        {
            [MethodImpl(Inline)]
            get => Source.AssemblyQualifiedName;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ClrTypeName src)
            => AssemblyQualifiedName.CompareTo(src.AssemblyQualifiedName);

        [MethodImpl(Inline)]
        public bool Equals(ClrTypeName src)
            => Source.Equals(src.Source);

        public override string ToString()
            => ShortName;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is ClrTypeName n && Equals(n);

        [MethodImpl(Inline)]
        public static bool operator <(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(ClrTypeName x, ClrTypeName y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrTypeName x, ClrTypeName y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ClrTypeName(Type src)
            => new ClrTypeName(src);
    }
}