//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;

    /// <summary>
    /// Captures an artifact classifier via parametricity
    /// </summary>
    public readonly struct ArtifactKind<K> : IArtifactKind<K>
        where K : unmanaged, IArtifactKind<K>
    {
        public TableIndex Index
            => default(K).Index;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKind<K>(K src)
            => default;
    }
}