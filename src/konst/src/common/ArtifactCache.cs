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
        static readonly ConcurrentDictionary<ArtifactIdentifier,object> Data = new ConcurrentDictionary<ArtifactIdentifier, object>();

        [MethodImpl(NotInline)]
        public static object acquire<T>(ArtifactIdentifier id, Func<ArtifactIdentifier,T> factory)
            => Data.GetOrAdd(id,factory);

        [MethodImpl(NotInline)]
        public static Option<T> search<T>(ArtifactIdentifier id)
        {
            if(Data.TryGetValue(id, out var dst))
                return some((T)dst);
            else
                return none<T>();
        }

        [MethodImpl(NotInline)]
        public static void insert<T>(ArtifactIdentifier id, T value)
            => Data[id] = value;
    }


    /// <summary>
    /// Defines a key-value association from an artifact to an entity of parametric type
    /// </summary>
    public readonly struct ArtifactCache<T>
    {
        static readonly ConcurrentDictionary<ArtifactIdentifier,T> Data = new ConcurrentDictionary<ArtifactIdentifier, T>();

        [MethodImpl(NotInline)]
        public static object acquire(ArtifactIdentifier id, Func<ArtifactIdentifier,T> factory)
            => Data.GetOrAdd(id,factory);

        [MethodImpl(NotInline)]
        public static Option<T> search(ArtifactIdentifier id)
        {
            if(Data.TryGetValue(id, out var dst))
                return some((T)dst);
            else
                return none<T>();
        }

        [MethodImpl(NotInline)]
        public static void insert(ArtifactIdentifier id, T value)
            => Data[id] = value;
    }
}