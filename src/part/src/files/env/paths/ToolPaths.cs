//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath ControlRoot()
            => Env.Control;

        FS.FolderPath ToolScriptRoot()
            => DevRoot(tooling) + FS.folder(tools);

        FS.FolderPath ToolExeRoot()
            => DbRoot() + FS.folder(tools);

        FS.FolderPath ToolDataRoot()
            => DbRoot() + FS.folder(tools);

        FS.FolderPath ToolScriptDir(ToolId tool)
            => ToolScriptRoot() + FS.folder(tool.Format());

        FS.FolderPath ToolOutDir(ToolId tool)
            => ToolDataRoot() + FS.folder(tool.Format()) + FS.folder(output);

        FS.FilePath ToolOutput(ToolId tool, string id, FS.FileExt ext)
            => ToolOutDir(tool) + FS.file(id, ext);

        FS.FolderPath ToolInDir(ToolId tool)
            => ToolDataRoot() + FS.folder(tool.Format()) + FS.folder(input);

        FS.FilePath ToolInput(ToolId tool,FS.FileName file)
            => ToolInDir(tool) + file;

        FS.FilePath ToolScript(ToolId tool, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(tool) + FS.file(script.Format(), ext ?? FS.Cmd);
    }
}