//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IArtifactTable<T> : ITable<T>
        where T : struct, IArtifactTable<T>
    {

    }

    [Free]
    public interface IArtifactTable<A,T>
        where T : struct, IArtifactTable<T>
        where A : struct
    {
        A Artifact {get;}

        T Table {get;}
    }

    [Free]
    public interface IArtifactTable<H,A,T> : IArtifactTable<A,T>
        where A : struct
        where T : struct, IArtifactTable<T>
        where H : struct, IArtifactTable<H,A,T>
    {
    }
}