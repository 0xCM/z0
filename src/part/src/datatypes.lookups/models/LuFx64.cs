//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Lookups
    {
        public readonly struct LuFx64<K>
            where K : unmanaged
        {
            readonly Index<ulong> KeyIndex;

            readonly Index<K> KeyValues;

            public uint EntryCount {get;}

            [MethodImpl(Inline)]
            internal LuFx64(ulong[] index, K[] values)
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
    }
}