//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public readonly struct HashIndex<T> : IIndex<T>
    {
        readonly Index<T> Data;

        readonly Dictionary<T,Paired<uint,T>> Keys;

        public HashIndex(Index<T> src)
        {
            Data = src;
            var count = src.Length;
            Keys = new Dictionary<T,Paired<uint,T>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var item = ref src[i];
                Keys.Add(item, (i,item));
            }
        }

        [MethodImpl(Inline)]
        public bool Contains(in T item)
            => Keys.ContainsKey(item);

        [MethodImpl(Inline)]
        public bool Index(in T item, out uint i)
        {
            if(Keys.TryGetValue(item, out var pair))
            {
                i = pair.Left;
                return true;
            }
            i = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public ref readonly T Item(uint index)
            => ref Data[index];

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }
    }
}