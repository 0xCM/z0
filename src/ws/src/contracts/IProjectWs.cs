//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WsAtoms;

    public interface IProjectWs : IWorkspace
    {
        ProjectId Project {get;}

        FS.FolderPath Home()
            => Root + FS.folder(Project.Format());

        FS.FolderPath IFileArchive.Subdir(string name)
            => Home() + FS.folder(name);

        FS.FolderPath IFileArchive.Subdir(Subject scope)
            => Home() + FS.folder(scope.Format());

        FS.FolderPath IWorkspace.OutDir()
            => Out();

        FS.FolderPath IWorkspace.OutDir(Subject scope)
            => Out(scope);

        FS.FolderPath IWorkspace.ScriptDir()
            => Home() + FS.folder(scripts);

        FS.FilePath IFileArchive.TablePath<T>()
            where T : struct
                => Tables() +  TableFile<T>();

        FS.FilePath IFileArchive.TablePath<T>(Subject scope)
            where T : struct
                => Subdir(scope) + TableFile<T>();

        FS.FilePath IFileArchive.TablePath<T>(Subject scope, string suffix)
            where T : struct
                => Subdir(scope) + TableFile<T>(suffix);

        FS.FolderPath Out()
            => Home() + FS.folder(output);

        FS.FolderPath Out(Subject scope)
            => Out() + FS.folder(scope.Format());

        FS.Files OutFiles()
            => Out().Files(true);

        FS.FolderPath DataOut()
            => Out(data);

        FS.FolderPath Tables()
            => Home() + FS.folder(tables);

        FS.FolderPath Tables(Subject scope)
            => Tables() + FS.folder(scope.Format());

        FS.FolderPath TablesOut()
            => Out(tables);

        FS.FilePath TableOut<T>()
            where T : struct
                => TablesOut() + FS.file(Z0.TableId.identify<T>().Format(), FS.Csv);

        FS.Files OutFiles(FS.FileExt ext)
            => Out().Files(ext, true);

        FS.Files OutFiles(ProjectId project, FileKind kind)
            => OutFiles(FileTypes.ext(kind));

        FS.Files OutFiles(params FileKind[] kinds)
            => Out().Files(true, kinds.Select(FileTypes.ext));

        FS.Files OutFiles(FS.FolderName subdir)
            => (Out() + subdir).Files(true);

        FS.Files OutFiles(FS.FolderName subdir, FS.FileExt ext)
            => (Out() + subdir).Files(ext,true);

        FS.Files DocFiles(ProjectId project)
            => Docs(project).Files(true);

        FS.FilePath Doc(ProjectId project, string fileid, FS.FileExt ext)
            => Docs(project) + FS.file(fileid, ext);

        FS.FolderPath Logs()
            => Home() + FS.folder(logs);

        FS.FolderPath Src()
            => Home() + FS.folder(src);

        FS.Files SrcFiles()
            => Src().Files(true);

        FS.Files SrcFiles(Subject scope)
            => (Src() + FS.folder(scope.Format())).AllFiles;

        FS.FilePath SrcFile(Subject scope, string fileid, FileKind kind)
            => Src() + FS.folder(scope.Format()) + FS.file(fileid, kind.Ext());

        FS.FolderPath Assets()
            => Home() + FS.folder(assets);

        FS.FolderPath Scripts()
            => Home() + FS.folder(scripts);

        FS.FolderPath Scripts(Subject scope)
            => Scripts() + FS.folder(scope.Format());

        FS.FilePath Script(Subject scope, ScriptId sid, FS.FileExt ext)
            => Scripts(scope) + FS.file(sid.Format(), ext);
    }
}