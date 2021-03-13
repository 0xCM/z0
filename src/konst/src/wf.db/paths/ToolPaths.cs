//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath ToolScriptRoot()
            => DevRoot("tooling") + FS.folder("scripts");

        FS.FolderPath ToolExeRoot()
            => DbRoot() + FS.folder(tools);

        FS.FolderPath ToolOutRoot()
            => DbRoot() + FS.folder(tools);

        FS.FolderPath ToolOutDir(ToolId tool)
            => ToolOutRoot() + FS.folder(tool.Format());

        FS.FolderPath Tools(ToolId id)
            => ToolExeRoot() + FS.folder(id.Format());

        FS.FolderPath Output(ToolId id)
            => Tools(id) + FS.folder(output);

        FS.FilePath ToolOutPath(ToolId tool, string id, FS.FileExt ext)
            => ToolOutDir(tool) + FS.file(id, ext);

        FS.Files ToolOutFiles(ToolId tool)
            => ToolOutDir(tool).EnumerateFiles(true).Array();

        FS.FolderPath ToolScriptDir(ToolId tool)
            => ToolScriptRoot() + FS.folder(tool.Format());

        FS.FilePath ToolScript(ToolId tool, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(tool) + FS.file(script.Format(), ext ?? FS.Extensions.Cmd);

        FS.FilePath Script(ToolId tool, FS.FileName file)
            => ToolScriptDir(tool) +  file;

        FS.FolderPath ToolScriptDir<K>(K kind)
            => ToolScriptRoot() + FS.folder(kind.ToString());

        FS.FilePath ToolScript<K>(K kind, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(kind) + FS.file(script.Format(), ext ?? FS.Extensions.Cmd);

        FS.FolderPath ToolCatalogRoot()
            => DevRoot("tooling") + FS.folder("catalog");

        FS.FolderPath Output(ToolId tool, CmdId cmd)
            => ToolExeRoot() + FS.folder(tool.Format()) + FS.folder(cmd.Format()) + FS.folder(output);
    }
}