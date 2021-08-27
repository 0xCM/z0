//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public sealed class ProjectWs : IProjectWs, IWorkspace<ProjectWs>
    {
        [MethodImpl(Inline)]
        public static ProjectWs create(FS.FolderPath src, FS.FolderPath dst)
            => new ProjectWs(src,dst);

        public FS.FolderPath Root {get; private set;}

        public FS.FolderPath OutRoot {get; private set;}

        public Identifier Name
        {
            [MethodImpl(Inline)]
            get => "projects";
        }

        Dictionary<ProjectId,ProjectConfig> ConfigLookup;

        public ProjectWs(FS.FolderPath src, FS.FolderPath dst)
        {
            Root = src;
            OutRoot = dst;
            ConfigLookup = dict<ProjectId,ProjectConfig>();
        }

        // public FS.FolderPath Home(ProjectId id)
        //     => Root + FS.folder(id.Format());

        // public FS.FolderPath Out(ProjectId id)
        //     => OutRoot + FS.folder(id.Format());

        // public FS.Files OutFiles(ProjectId id)
        //     => Out(id).Files(true);

        // public FS.Files OutFiles(ProjectId id, FS.FileExt ext)
        //     => Out(id).Files(ext, true);

        // public FS.Files OutFiles(ProjectId id, FS.FolderName subdir)
        //     => (Out(id) + subdir).Files(true);

        // public FS.Files OutFiles(ProjectId id, FS.FolderName subdir, FS.FileExt ext)
        //     => (Out(id) + subdir).Files(ext,true);

        // public FS.FolderPath Docs(ProjectId id)
        //     => Home(id) + FS.folder(docs);

        // public FS.Files DocFiles(ProjectId id)
        //     => Docs(id).Files(true);

        // public FS.FilePath Doc(ProjectId project, string fileid, FS.FileExt ext)
        //     => Docs(project) + FS.file(fileid, ext);

        // public FS.FolderPath Logs(ProjectId id)
        //     => Home(id) + FS.folder(logs);

        // public FS.Files LogFiles(ProjectId id)
        //     => Logs(id).Files(true);

        // public FS.FilePath Log(ProjectId project, string fileid)
        //     => Logs(project) + FS.file(fileid, FS.Log);

        // public FS.FolderPath Src(ProjectId id)
        //     => Home(id) + FS.folder(src);

        // public FS.Files SrcFiles(ProjectId id)
        //     => Src(id).Files(true);

        // public FS.FilePath Src(ProjectId project, string fileid, FS.FileExt ext)
        //     => Src(project) + FS.file(fileid,ext);

        // public FS.FolderPath Assets(ProjectId id)
        //     => Home(id) + FS.folder(assets);

        public bool Settings(ProjectId id, out ProjectConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ProjectId id, in ProjectConfig src)
            => ConfigLookup[id] = src;
    }
}