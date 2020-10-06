//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Lookups
    {
        public readonly struct LuFx64<K>
            where K : unmanaged
        {
            readonly TableSpan<ulong> KeyIndex;

            readonly TableSpan<K> KeyValues;

            public readonly uint EntryCount;

            [MethodImpl(Inline)]
            internal LuFx64(TableSpan<ulong> index, TableSpan<K> values)
            {
                KeyIndex = index;
                KeyValues = values;
                EntryCount = (uint)index.Length;
            }

            [MethodImpl(Inline)]
            public LuFx64(Paired<ulong,K>[] src)
            {
                EntryCount = (uint)src.Length;
                KeyValues = alloc<K>(src.Length);
                KeyIndex = alloc<ulong>(src.Length);
                for(var i=0; i< KeyValues.Length; i++)
                {
                    KeyIndex[i] = src[i].Left;
                    KeyValues[i] = src[i].Right;
                }
            }

            [MethodImpl(Inline)]
            public ref ulong Index(uint i)
                => ref KeyIndex[i];

            [MethodImpl(Inline)]
            public ref K Key(uint i)
                => ref KeyValues[i];

        }

        /// <summary>
        /// Defines an 8-bit lookup table predicated on an explicit lookup function
        /// </summary>
        public readonly struct Lu8<V>
        {
            readonly LookupTable<byte,V> Entries;

            [MethodImpl(Inline)]
            public Lu8(LookupTable<byte,V> src)
            {
                Entries = src;
            }
        }


        /// <summary>
        /// Defines a 16-bit lookup tablee
        /// </summary>
        public readonly struct Lu16<V>
        {
            readonly LookupTable<ushort,V> Entries;

            [MethodImpl(Inline)]
            public Lu16(LookupTable<ushort,V> src)
            {
                Entries = src;
            }
        }

        /// <summary>
        /// Defines a 32-bit lookup tablee
        /// </summary>
        public readonly struct Lu32<V>
        {
            readonly LookupTable<uint,V> Entries;

            [MethodImpl(Inline)]
            public Lu32(LookupTable<uint,V> src)
            {
                Entries = src;
            }
        }

        /// <summary>
        /// Defines a 64-bit lookup tablee
        /// </summary>
        public readonly struct Lu64<V>
        {
            readonly LookupTable<ulong,V> Entries;

            [MethodImpl(Inline)]
            public Lu64(LookupTable<ulong,V> src)
            {
                Entries = src;
            }
        }
    }
}