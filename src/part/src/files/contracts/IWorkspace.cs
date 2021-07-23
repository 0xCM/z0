//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkspace : IFileArchive
    {
        Identifier Name {get;}
    }

    public interface IWorkspace<T> : IWorkspace
        where T : IWorkspace<T>, new()
    {
        FS.FolderPath WsRoot();

        FS.FolderPath WsRoot(FS.FolderPath src);

        Identifier IWorkspace.Name
            => WsRoot().FolderName.Format();
    }
}