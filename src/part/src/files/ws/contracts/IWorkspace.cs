//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WsAtoms;

    public interface IWorkspace : IFileArchive
    {
        Identifier Name {get;}

        FS.FolderPath ScriptDir()
            => Root + FS.folder(scripts);

        FS.FilePath Script(ScriptId id)
            => ScriptDir()+ FS.file(id.Format(), FS.Cmd);

        FS.FolderPath WsDocs()
            => Root + FS.folder(docs);

        FS.FolderPath WsDocs(string id)
            => WsDocs() + FS.folder(id);

        /// <summary>
        /// Defines a path of the form {Root}/.out
        /// </summary>
        FS.FolderPath OutDir()
            => Root + FS.folder(output);

        FS.FolderPath OutDir(string id)
            => OutDir() + FS.folder(id);

        FS.FolderPath Settings()
            => Root + FS.folder("settings");

        FS.FilePath Settings(string id, FS.FileExt ext)
            => Settings() + FS.file(id, ext);
    }

    public interface IWorkspace<T> : IWorkspace
        where T : IWorkspace<T>
    {
        FS.FolderPath WsRoot() => Root;

        Identifier IWorkspace.Name
            => WsRoot().FolderName.Format();
    }
}