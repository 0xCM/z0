//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a key-value association from an artifact to an entity of parametric type
    /// </summary>
    public readonly struct ClrArtifactCache<T>
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