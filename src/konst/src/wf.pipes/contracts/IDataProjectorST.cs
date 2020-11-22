//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataProjector<S,T>
        where S : struct
        where T : struct
    {
        void Project(in S src, out T dst);
    }

    [Free]
    public interface IDataProjector<H,S,T> : IDataProjector<S,T>
        where S : struct
        where T : struct
        where H : struct, IDataProjector<H,S,T>
    {

    }
}