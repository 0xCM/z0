//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WsAtoms;

    public interface IToolWs : IWorkspace
    {
        FS.FolderPath Home(ToolId id)
            => Root + FS.folder(id.Format());

        FS.FolderPath Docs(ToolId id)
            => Home(id) + FS.folder(docs);

        FS.FolderPath Logs(ToolId id)
            => Home(id) + FS.folder(logs);

        FS.FolderPath Scripts(ToolId id)
            => Home(id) + FS.folder(scripts);

        FS.FolderPath Samples(ToolId id)
            => Home(id) + FS.folder(samples);

        FS.FilePath Script(string id)
            => Root + FS.file(id,FS.Cmd);

        FS.FilePath Script(ToolId tool, string id)
            => Scripts(tool) + FS.file(id,FS.Cmd);

        FS.FilePath ConfigScript(ToolId id)
            => Home(id) + FS.file(config, FS.Cmd);

        FS.FilePath ConfigLog(ToolId id)
            => Logs(id) + FS.file(config, FS.Log);

        FS.FilePath Inventory()
            => Root + FS.folder(admin) + FS.file(inventory, FS.Txt);
    }
}