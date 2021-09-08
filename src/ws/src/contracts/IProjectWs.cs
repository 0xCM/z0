//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WsAtoms;

    public interface IProjectWs : IWorkspace
    {
        FS.FolderPath Home(ProjectId project)
            => Root + FS.folder(project.Format());

        FS.FolderPath Out(ProjectId project)
            => Home(project) + FS.folder(output);

        FS.FolderPath Out(ProjectId project, Scope scope)
            => Out(project) + FS.folder(scope.Format());

        FS.Files OutFiles(ProjectId project)
            => Out(project).Files(true);

        FS.FolderPath DataOut(ProjectId project)
            => Out(project, data);

        FS.FolderPath TablesOut(ProjectId project)
            => Out(project, tables);

        FS.FilePath TableOut<T>(ProjectId project)
            where T : struct
                => TablesOut(project) + FS.file(Z0.TableId.identify<T>().Format(), FS.Csv);

        FS.Files OutFiles(ProjectId project, FS.FileExt ext)
            => Out(project).Files(ext, true);

        FS.Files OutFiles(ProjectId project, FileKind kind)
            => OutFiles(project, FileTypes.ext(kind));

        FS.Files OutFiles(ProjectId project, params FileKind[] kinds)
            => Out(project).Files(true, kinds.Select(FileTypes.ext));

        FS.Files OutFiles(ProjectId project, FS.FolderName subdir)
            => (Out(project) + subdir).Files(true);

        FS.Files OutFiles(ProjectId project, FS.FolderName subdir, FS.FileExt ext)
            => (Out(project) + subdir).Files(ext,true);

        FS.FolderPath Docs(ProjectId project)
            => Home(project) + FS.folder(docs);

        FS.Files DocFiles(ProjectId project)
            => Docs(project).Files(true);

        FS.FilePath Doc(ProjectId project, string fileid, FS.FileExt ext)
            => Docs(project) + FS.file(fileid, ext);

        FS.FolderPath Logs(ProjectId project)
            => Home(project) + FS.folder(logs);

        FS.Files LogFiles(ProjectId project)
            => Logs(project).Files(true);

        FS.FilePath Log(ProjectId project, string fileid)
            => Logs(project) + FS.file(fileid, FS.Log);

        FS.FolderPath Src(ProjectId project)
            => Home(project) + FS.folder(src);

        FS.Files SrcFiles(ProjectId project)
            => Src(project).Files(true);

        FS.Files SrcFiles(ProjectId project, Scope scope)
            => (Src(project) + FS.folder(scope.Format())).AllFiles;

        FS.FilePath SrcFile(ProjectId project, string fileid, FS.FileExt ext)
            => Src(project) + FS.file(fileid,ext);

        FS.FolderPath Assets(ProjectId project)
            => Home(project) + FS.folder(assets);

        FS.FolderPath Scripts(ProjectId project)
            => Home(project) + FS.folder(scripts);

        FS.FolderPath Scripts(ProjectId project, Scope scope)
            => Scripts(project) + FS.folder(scope.Format());

        FS.FilePath Script(ProjectId project, Scope scope, ScriptId sid, FS.FileExt ext)
            => Scripts(project,scope) + FS.file(sid.Format(), ext);

        FS.FilePath Script(ProjectId project, ScriptId sid, FS.FileExt ext)
            => Scripts(project) + FS.file(sid.Format(), ext);
    }
}