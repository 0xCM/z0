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
    public readonly partial struct ArtifactModels
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TypeRef<T> reference<T>(T t = default)
            => default;

        [MethodImpl(Inline), Op]
        public static ArtifactKey key(ArtifactKind kind, ClrArtifactKey id)
            => new ArtifactKey(kind,id);

        [MethodImpl(Inline)]
        public static ArtifactTable<H,A,T> table<H,A,T>(A artifact, T table, H host = default)
            where A : struct
            where T : struct, IArtifactTable<T>
            where H : struct
                => new ArtifactTable<H,A,T>(artifact,table);
    }
}