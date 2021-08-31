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

        FS.FolderPath DataDir()
            => Root + FS.folder(data);

        FS.FolderPath AdminDir()
            => Root + FS.folder(admin);

        FS.FilePath AdminPath(string id, FS.FileExt ext)
            => AdminDir() + FS.file(id,ext);

        FS.Files AdminFiles()
            => AdminDir().AllFiles;

        FS.Files AdminFiles(FS.FileExt ext)
            => AdminDir().Files(ext);

        FS.FilePath LlvmTable(string id)
            => Root + FS.folder(llvm) + FS.file(id, FS.Csv);

        FS.FilePath LlvmTable<T>()
            where T : struct
                => Root + FS.folder(llvm) + TableFile<T>();

        FS.FolderPath SrcDir()
            => Root + FS.folder(src);

        FS.FolderPath SrcDir(string name)
            => SrcDir() + FS.folder(name);

        FS.FolderPath OutDir()
            => Root + FS.folder(output);

        FS.FolderPath OutDir(string id)
            => OutDir() + FS.folder(id);

        FS.FolderPath ScriptDir()
            => Root + FS.folder(scripts);

        FS.FolderPath ObjSymDir()
            => OutDir() + FS.folder(sym);

        FS.FilePath ObjSymPath(string id)
            => ObjSymDir() + FS.file(id,FS.Sym);

        FS.FilePath Script(string id)
            => ScriptDir() + FS.file(id,FS.Cmd);

        FS.FolderPath Docs()
            => Root + FS.folder(docs);

        FS.FolderPath Docs(string id)
            => Docs() + FS.folder(id);

        FS.FilePath Doc(string id, FS.FileExt ext)
            => Docs() + FS.file(id,ext);

        FS.FolderPath Bin()
            => OutDir() + FS.folder(bin);

        FS.FilePath BinPath(string id)
            => Bin() + FS.file(id, FS.Bin);

        FS.FolderPath HexOutDir()
            => OutDir() + FS.folder(hex);

        FS.FolderPath HexSrcDir()
            => SrcDir(hex);

        FS.FolderPath ObjOut()
            => OutDir() + FS.folder(obj);

        FS.FilePath ObjPath(string id)
            => ObjOut() + FS.file(id,FS.Obj);

        FS.FolderPath ExeOut()
            => OutDir() + FS.folder(exe);

        FS.FilePath ExePath(string id)
            => ExeOut() + FS.file(id,FS.Exe);

        FS.FolderPath Settings()
            => Root + FS.folder(settings);

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