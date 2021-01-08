//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Storage = KeyedValues<ClrToken,System.Type>;
    using T = KeyedValue<ClrToken,System.Type>;
    using V = System.Type;
    using K = ClrToken;

    [ApiType(ApiNames.ClrTypes, true)]
    public readonly struct ClrTypeLookup
    {
        readonly Storage Data;

        [MethodImpl(Inline)]
        static K kf(in V t)
            => t.MetadataToken;

        [MethodImpl(Inline)]
        public ClrTypeLookup(V[] src)
            => Data = new Storage(kf, src);

        [MethodImpl(Inline)]
        public ClrTypeLookup(Storage src)
            => Data = src;

        public ref V this[in K id]
        {
            [MethodImpl(Inline)]
            get => ref Data[id];
        }

        public ref T this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        [MethodImpl(Inline)]
        public bool Search(Func<Type,bool> predicate, out Type found)
            => Data.Search(predicate, out found);

        public Span<T> Pairs
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}