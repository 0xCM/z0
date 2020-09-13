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

    public interface IClrArtifactTable<A,T>
        where T : struct, IClrTable<T>
        where A : struct, IClrArtifact<A>
    {
        A Artifact {get;}

        T Table {get;}
    }

    public interface IClrArtifactTable<H,A,T> : IClrArtifactTable<A,T>
        where A : struct, IClrArtifact<A>
        where T : struct, IClrTable<T>
        where H : struct, IClrArtifactTable<H,A,T>
    {
    }

    public readonly struct ClrArtifactTable<H,A,T> : IClrArtifactTable<ClrArtifactTable<H,A,T>,A,T>
        where H : struct
        where T : struct, IClrTable<T>
        where A : struct, IClrArtifact<A>
    {
        public A Artifact {get;}

        public T Table {get;}
    }
}