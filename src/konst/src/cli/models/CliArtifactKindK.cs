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
    public readonly struct CliArtifactKind<K> : ICliRowKind<K>
        where K : unmanaged, ICliRowKind<K>
    {
        public TableIndex Index
            => default(K).Index;

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKind<K>(K src)
            => default;
    }
}