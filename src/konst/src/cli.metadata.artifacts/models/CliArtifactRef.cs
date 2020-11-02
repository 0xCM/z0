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
    /// Defines a reference to an artifact
    /// </summary>
    public readonly struct CliArtfactRef
    {
        public readonly ClrArtifactKey Id;

        [MethodImpl(Inline)]
        public CliArtfactRef(Type t)
        {
            Id = t.MetadataToken;
        }

        [MethodImpl(Inline)]
        public CliArtfactRef(ClrArtifactKey src)
        {
            Id = src;
        }
    }
}