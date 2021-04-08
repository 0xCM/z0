//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath ToolScriptRoot()
            => DevRoot(tooling) + FS.folder(tools);

        FS.FolderPath ToolExeRoot()
            => DbRoot() + FS.folder(tools);

        FS.FolderPath ToolDataRoot()
            => DbRoot() + FS.folder(tools);

        FS.FolderPath ToolCatalogRoot()
            => DevRoot("tooling") + FS.folder("catalog");

        FS.FolderPath ToolHelpRoot()
            => ToolCatalogRoot() + FS.folder(help);

        FS.FolderPath ToolsetHelpDir(string toolset)
            => ToolHelpRoot() + FS.folder(toolset);

        FS.Files ToolsetHelpFiles(string toolset)
            => ToolsetHelpDir(toolset).AllFiles;

        FS.FolderPath ToolOutDir(ToolId tool)
            => ToolDataRoot() + FS.folder(tool.Format()) + FS.folder(output);

        FS.FolderPath ToolExeRoot(ToolId id)
            => ToolExeRoot() + FS.folder(id.Format());

        FS.FilePath ToolOutput(ToolId tool, string id, FS.FileExt ext)
            => ToolOutDir(tool) + FS.file(id, ext);

        FS.FilePath ToolOutput(ToolId tool, FS.FileName file)
            => ToolOutDir(tool) + file;

        FS.Files ToolOutFiles(ToolId tool)
            => ToolOutDir(tool).EnumerateFiles(true).Array();

        FS.FolderPath ToolInDir(ToolId tool)
            => ToolDataRoot() + FS.folder(tool.Format()) + FS.folder(input);

        FS.FilePath ToolInput(ToolId tool,string id, FS.FileExt ext)
            => ToolInDir(tool) + FS.file(id,ext);

        FS.FilePath ToolInput(ToolId tool,FS.FileName file)
            => ToolInDir(tool) + file;

        FS.FolderPath ToolScriptDir(ToolId tool)
            => ToolScriptRoot() + FS.folder(tool.Format());

        FS.FilePath ToolScript(ToolId tool, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(tool) + FS.file(script.Format(), ext ?? FS.Cmd);

        FS.FilePath ToolScript(ToolId tool, FS.FileName file)
            => ToolScriptDir(tool) +  file;

        FS.FolderPath ToolScriptDir<K>(K kind)
            => ToolScriptRoot() + FS.folder(kind.ToString());

        FS.FilePath ToolScript<K>(K kind, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(kind) + FS.file(script.Format(), ext ?? FS.Cmd);

        FS.FolderPath Output(ToolId tool, CmdId cmd)
            => ToolExeRoot() + FS.folder(tool.Format()) + FS.folder(cmd.Format()) + FS.folder(output);
    }
}