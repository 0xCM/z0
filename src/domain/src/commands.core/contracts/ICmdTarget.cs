//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdTarget
    {
        FS.FilePath Path {get;}
    }

    [Free]
    public interface ICmdTarget<T> : ICmdTarget
        where T : struct, ITool<T>
    {
        T Tool => default(T);

    }

    [Free]
    public interface ICmdTarget<T,F> : ICmdTarget<T>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {

    }
}