//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface IArtifactTable<T> : ITable<T>
        where T : struct, IArtifactTable<T>
    {
    }

    public interface IArtifactTable<A,T>
        where T : struct, IArtifactTable<T>
        where A : struct, IClrArtifact<A>
    {
        A Artifact {get;}

        T Table {get;}
    }

    public interface IArtifactTable<H,A,T> : IArtifactTable<A,T>
        where A : struct, IClrArtifact<A>
        where T : struct, IArtifactTable<T>
        where H : struct, IArtifactTable<H,A,T>
    {
    }

    public readonly struct ArtifactTable<H,A,T> : IArtifactTable<ArtifactTable<H,A,T>,A,T>
        where H : struct
        where T : struct, IArtifactTable<T>
        where A : struct, IClrArtifact<A>
    {
        public A Artifact {get;}

        public T Table {get;}
    }
}