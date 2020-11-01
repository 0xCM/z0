//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ArtifactTable<H,A,T> : IArtifactTable<ArtifactTable<H,A,T>,A,T>
        where A : struct
        where T : struct, IArtifactTable<T>
        where H : struct
    {
        public A Artifact {get;}

        public T Table {get;}

        [MethodImpl(Inline)]
        public ArtifactTable(A artifact, T table)
        {
            Artifact = artifact;
            Table = table;
        }
    }
}