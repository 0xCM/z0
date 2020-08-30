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

    [ApiHost]
    public readonly partial struct ArtifactModel
    {
        [MethodImpl(Inline), Op]
        public static ArtifactKey key(ArtifactKind kind, ArtifactIdentifier id)
            => new ArtifactKey(kind,id);
    }

}