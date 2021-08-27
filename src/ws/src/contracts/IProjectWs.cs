//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WsAtoms;

    public interface IProjectWs : IWorkspace
    {
        FS.FolderPath OutRoot {get;}

        FS.FolderPath Home(ProjectId id)
            => Root + FS.folder(id.Format());

        FS.FolderPath Out(ProjectId id)
            => OutRoot + FS.folder(id.Format());

        FS.Files OutFiles(ProjectId id)
            => Out(id).Files(true);

        FS.Files OutFiles(ProjectId id, FS.FileExt ext)
            => Out(id).Files(ext, true);

        FS.Files OutFiles(ProjectId id, FS.FolderName subdir)
            => (Out(id) + subdir).Files(true);

        FS.Files OutFiles(ProjectId id, FS.FolderName subdir, FS.FileExt ext)
            => (Out(id) + subdir).Files(ext,true);

        FS.FolderPath Docs(ProjectId id)
            => Home(id) + FS.folder(docs);

        FS.Files DocFiles(ProjectId id)
            => Docs(id).Files(true);

        FS.FilePath Doc(ProjectId project, string fileid, FS.FileExt ext)
            => Docs(project) + FS.file(fileid, ext);

        FS.FolderPath Logs(ProjectId id)
            => Home(id) + FS.folder(logs);

        FS.Files LogFiles(ProjectId id)
            => Logs(id).Files(true);

        FS.FilePath Log(ProjectId project, string fileid)
            => Logs(project) + FS.file(fileid, FS.Log);

        FS.FolderPath Src(ProjectId id)
            => Home(id) + FS.folder(src);

        FS.Files SrcFiles(ProjectId id)
            => Src(id).Files(true);

        FS.FilePath Src(ProjectId project, string fileid, FS.FileExt ext)
            => Src(project) + FS.file(fileid,ext);

        FS.FolderPath Assets(ProjectId id)
            => Home(id) + FS.folder(assets);

        FS.FolderPath WsRoot()
            => Root;

        FS.FolderPath Scripts(ProjectId id)
            => Home(id) + FS.folder(scripts);

        FS.FolderPath Scripts(ProjectId id, Scope scope)
            => Scripts(id) + FS.folder(scope.Format());

        FS.FilePath Script(ProjectId id, Scope scope, ScriptId sid, FS.FileExt ext)
            => Scripts(id,scope) + FS.file(sid.Format(), ext);

        FS.FilePath Script(ProjectId id, ScriptId sid, FS.FileExt ext)
            => Scripts(id) + FS.file(sid.Format(), ext);
    }
}