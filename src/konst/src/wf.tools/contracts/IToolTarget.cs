//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolTarget
    {
        FS.FilePath Path {get;}
    }

    [Free]
    public interface IToolTarget<T> : IToolTarget
        where T : struct, ITool<T>
    {
        T Tool => default(T);

    }

    [Free]
    public interface IToolTarget<T,F> : IToolTarget<T>
        where T : struct, ITool<T>
        where F : unmanaged
    {

    }
}