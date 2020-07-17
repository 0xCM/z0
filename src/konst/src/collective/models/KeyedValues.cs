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

    /// <summary>
    /// Defines a T-value index together with a comanion K-index ,
    /// where each K-value i is either obtained directly from the caller or by 
    /// invoking a caller-supplied index function f:T -> K that computes a uniqe K-value for each T-value
    /// </summary>
    public readonly struct KeyedValues<K,V> : IIndex<KeyedValue<K,V>>
        where K : unmanaged, IEquatable<K>
    {
        public readonly KeyedValue<K,V>[] Pairs;        
        
        readonly KeyFunction<K,V> KeyFunction;

        public ReadOnlySpan<KeyedValue<K,V>> View
        {
            [MethodImpl(Inline)]
            get => Pairs;
        }

        public Span<KeyedValue<K,V>> Edit
        {
            [MethodImpl(Inline)]
            get => Pairs;
        }

        [MethodImpl(Inline)]
        public ref KeyedValue<K,V> Pair(uint index)
            => ref Pairs[index];

        [MethodImpl(Inline)]
        public bool Search(in K key, out V value)
        {
            var view = View;
            for(var i=0; i<view.Length; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(key.Equals(candidate))
                {
                    value = skip(view, i).Value;
                    return true;
                }
            }
            value = default;
            return false;
        }

        [MethodImpl(Inline)]
        public bool Search(Func<V,bool> predicate, out V found)
        {
            var view = View;
            for(var i=0; i<view.Length; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(predicate(candidate.Value))
                {
                    found = candidate.Value;
                    return true;
                }
            }
            found = default;
            return false;
        }
        

        [MethodImpl(Inline)]
        public KeyedValues(V[] src, KeyFunction<K,V> kf, KeyedValue<K,V>[] dst)
        {
            Pairs = dst;
            KeyFunction = kf;

            var edit = Edit;
            var values = span(src);
            var count = src.Length;
            for(var i= 0u; i<count; i++)
            {   
                ref readonly var value = ref skip(values,i);
                var key = kf(value);

                seek(edit,i) = kvp(key,value);

            }
        }

        public ref KeyedValue<K,V> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Pair(index);
        }

        public ref KeyedValue<K,V> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Pair((uint)index);
        }

        [MethodImpl(Inline)]
        public ref K Key(uint index)
            => ref Pairs[index].Key;

        [MethodImpl(Inline)]
        public ref V Value(uint index)
            => ref Pairs[index].Value;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Pairs.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Pairs.Length;
        }
    }
}