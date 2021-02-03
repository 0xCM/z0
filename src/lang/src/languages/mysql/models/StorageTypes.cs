//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using A = MySql.TypeAffinityKind;

    public readonly partial struct MySql
    {
        public readonly partial struct StorageTypes
        {
            public readonly struct Null : IFixedStorageType<Null>
            {
                public string Name => "null";

                public ByteSize Size => 0;

                public A Affinity => 0;

            }

            public readonly struct Int<T> : IFixedStorageType<T>
            {
                public string Name => "integer";

                public ByteSize Size
                    => memory.size<T>();

                public A Affinity
                    => A.Integer;
            }

            public readonly struct Int8 : IFixedStorageType<byte>
            {
                public string Name
                    => default(Int<byte>).Name;

                public ByteSize Size
                    => default(Int<byte>).Size;

                public A Affinity
                    => default(Int<byte>).Affinity;
            }

            public readonly struct Int16 : IFixedStorageType<ushort>
            {
                public string Name
                    => default(Int<ushort>).Name;

                public ByteSize Size
                    => default(Int<ushort>).Size;

                public A Affinity
                    => default(Int<ushort>).Affinity;
            }

            public readonly struct Int32 : IFixedStorageType<uint>
            {
                public string Name
                    => default(Int<uint>).Name;

                public ByteSize Size
                    => default(Int<uint>).Size;

                public A Affinity
                    => default(Int<uint>).Affinity;
            }

            public readonly struct Int64 : IFixedStorageType<ulong>
            {
                public string Name
                    => default(Int<ulong>).Name;

                public ByteSize Size
                    => default(Int<ulong>).Size;

                public A Affinity
                    => default(Int<ulong>).Affinity;
            }

            public readonly struct Real : IFixedStorageType<double>
            {
                public string Name => "real";

                public ByteSize Size
                    => memory.size<double>();

                public A Affinity
                    => A.Real;
            }

            public readonly struct SqlText : IStorageType<char[]>
            {
                public string Name => "text";

                public A Affinity
                    => A.Text;
            }

            public readonly struct SqlBlob : IStorageType<byte[]>
            {
                public string Name => "blob";

                public A Affinity
                    => A.Blob;
            }
        }
    }
}