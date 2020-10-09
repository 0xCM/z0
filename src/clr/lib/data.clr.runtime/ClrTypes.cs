//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using Storage = KeyedValues<ClrArtifactKey,System.Type>;
    using T = KeyedValue<ClrArtifactKey,System.Type>;
    using V = System.Type;
    using K = ClrArtifactKey;

    [ApiDataType(ApiNames.ClrTypes, true)]
    public readonly struct ClrTypes
    {
        [MethodImpl(Inline)]
        public static ClrTypes create(ReadOnlySpan<V> src)
            => new ClrTypes(src);

        [MethodImpl(Inline)]
        public static ClrTypes init(uint capacity)
            => new ClrTypes(new Storage(kf,capacity));

        readonly Storage Data;

        [MethodImpl(Inline)]
        static K kf(in V t)
            => t.MetadataToken;

        [MethodImpl(Inline)]
        public ClrTypes(ReadOnlySpan<V> src)
            => Data = new Storage(kf, src);

        [MethodImpl(Inline)]
        public ClrTypes(Storage src)
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