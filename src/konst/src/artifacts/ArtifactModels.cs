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

    public readonly partial struct ArtifactModels
    {

        [MethodImpl(Inline)]
        public static ArtifactTable<H,A,T> table<H,A,T>(A artifact, T table, H host = default)
            where A : struct
            where T : struct, IArtifactTable<T>
            where H : struct
                => new ArtifactTable<H,A,T>(artifact,table);
    }
}