//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a key-value association from an artifact to an entity of arbitrary type
    /// </summary>
    public readonly struct ArtifactCache
    {
        static readonly ConcurrentDictionary<ClrArtifactKey,object> Data = new ConcurrentDictionary<ClrArtifactKey, object>();

        [MethodImpl(NotInline)]
        public static object acquire<T>(ClrArtifactKey id, Func<ClrArtifactKey,T> factory)
            => Data.GetOrAdd(id,factory);

        [MethodImpl(NotInline)]
        public static Option<T> search<T>(ClrArtifactKey id)
        {
            if(Data.TryGetValue(id, out var dst))
                return some((T)dst);
            else
                return none<T>();
        }

        [MethodImpl(NotInline)]
        public static void insert<T>(ClrArtifactKey id, T value)
            => Data[id] = value;
    }


    /// <summary>
    /// Defines a key-value association from an artifact to an entity of parametric type
    /// </summary>
    public readonly struct ArtifactCache<T>
    {
        static readonly ConcurrentDictionary<ClrArtifactKey,T> Data = new ConcurrentDictionary<ClrArtifactKey, T>();

        [MethodImpl(NotInline)]
        public static object acquire(ClrArtifactKey id, Func<ClrArtifactKey,T> factory)
            => Data.GetOrAdd(id,factory);

        [MethodImpl(NotInline)]
        public static Option<T> search(ClrArtifactKey id)
        {
            if(Data.TryGetValue(id, out var dst))
                return some((T)dst);
            else
                return none<T>();
        }

        [MethodImpl(NotInline)]
        public static void insert(ClrArtifactKey id, T value)
            => Data[id] = value;
    }
}