//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static TypeAffinityKind;

    public enum TypeAffinityKind : byte
    {
        None = 0,

        Text = 1,

        Numeric = 2,

        Integer = 4,

        Real = 8,

        Blob = 16
    }

    public interface IStorageType<T>
    {
        string Name {get;}

        TypeAffinityKind Affinity {get;}
    }

    public interface IFixedStorageType<T> : IStorageType<T>
    {
        ByteSize Size {get;}
    }

    public readonly partial struct StorageTypes
    {
        public readonly struct Null : IFixedStorageType<Null>
        {
            public string Name => "null";

            public ByteSize Size => 0;

            public TypeAffinityKind Affinity => None;
        }

        public readonly struct Int<T> : IFixedStorageType<T>
        {
            public string Name => "integer";

            public ByteSize Size
                => memory.size<T>();

            public TypeAffinityKind Affinity
                => Integer;
        }

        public readonly struct Int8 : IFixedStorageType<byte>
        {
            public string Name
                => default(Int<byte>).Name;

            public ByteSize Size
                => default(Int<byte>).Size;

            public TypeAffinityKind Affinity
                => default(Int<byte>).Affinity;
        }

        public readonly struct Int16 : IFixedStorageType<ushort>
        {
            public string Name
                => default(Int<ushort>).Name;

            public ByteSize Size
                => default(Int<ushort>).Size;

            public TypeAffinityKind Affinity
                => default(Int<ushort>).Affinity;
        }

        public readonly struct Int32 : IFixedStorageType<uint>
        {
            public string Name
                => default(Int<uint>).Name;

            public ByteSize Size
                => default(Int<uint>).Size;

            public TypeAffinityKind Affinity
                => default(Int<uint>).Affinity;
        }

        public readonly struct Int64 : IFixedStorageType<ulong>
        {
            public string Name
                => default(Int<ulong>).Name;

            public ByteSize Size
                => default(Int<ulong>).Size;

            public TypeAffinityKind Affinity
                => default(Int<ulong>).Affinity;
        }

        public readonly struct Real : IFixedStorageType<double>
        {
            public string Name => "real";

            public ByteSize Size
                => memory.size<double>();

            public TypeAffinityKind Affinity
                => TypeAffinityKind.Real;
        }

        public readonly struct SqlText : IStorageType<char[]>
        {
            public string Name => "text";

            public TypeAffinityKind Affinity => Text;
        }

        public readonly struct SqlBlob : IStorageType<byte[]>
        {
            public string Name => "blob";

            public TypeAffinityKind Affinity => Blob;
        }
    }
}