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

        FS.FilePath Script(string id)
            => Root + FS.file(id,FS.Cmd);

        FS.FolderPath Docs()
            => Root + FS.folder(docs);

        FS.FolderPath Docs(string id)
            => Docs() + FS.folder(id);

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

        FS.FolderPath ToolHome(ToolId id)
            => Root + FS.folder(id.Format());

        FS.FolderPath ToolDocs(ToolId id)
            => ToolHome(id) + FS.folder(docs);

        FS.FolderPath Logs(ToolId id)
            => ToolHome(id) + FS.folder(logs);

        FS.FolderPath Scripts(ToolId id)
            => ToolHome(id) + FS.folder(scripts);

        FS.FilePath Script(ToolId tool, string id)
            => Scripts(tool) + FS.file(id,FS.Cmd);

        FS.FilePath ConfigScript(ToolId id)
            => ToolHome(id) + FS.file(config, FS.Cmd);

        FS.FilePath ConfigLog(ToolId id)
            => Logs(id) + FS.file(config, FS.Log);

        FS.FilePath Inventory()
            => Root + FS.folder(admin) + FS.file(inventory, FS.Txt);
    }

    public interface IWorkspace<T> : IWorkspace
        where T : IWorkspace<T>
    {
        FS.FolderPath WsRoot() => Root;

        Identifier IWorkspace.Name
            => WsRoot().FolderName.Format();
    }
}