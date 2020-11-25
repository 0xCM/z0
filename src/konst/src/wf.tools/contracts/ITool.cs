//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITool : IIdentified<CmdHostId>
    {
        FS.FolderPath Source
            => FS.FolderPath.Empty;
    }

    [Free]
    public interface ITool<T> : ITool
        where T : struct, ITool<T>
    {

    }

    [Free]
    public interface ITool<T,F> : ITool<T>, ICmdOption<F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {

    }
}