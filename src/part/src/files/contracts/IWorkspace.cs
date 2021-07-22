//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkspace : IFileArchive
    {

    }

    public interface IWorkspace<T> : IWorkspace
        where T : IWorkspace<T>, new()
    {
        FS.FolderPath WsRoot();

        FS.FolderPath WsRoot(FS.FolderPath src);
    }
}