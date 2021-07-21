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

    public sealed class ProjectBase : Service<ProjectBase>, IFileArchive
    {
        const string docs = nameof(docs);

        const string logs = ".logs";

        const string src = nameof(src);

        const string assets = nameof(assets);

        const string output = ".out";

        public FS.FolderPath Root {get; private set;}

        Dictionary<ProjectId,ProjectConfig> ConfigLookup;

        IRecordFormatter<ProjectConfig> ConfigFormatter;

        public ProjectBase()
        {
            ConfigLookup = dict<ProjectId,ProjectConfig>();
            ConfigFormatter = Tables.formatter<ProjectConfig>();
        }

        public FS.FolderPath Home(ProjectId id)
            => Root + FS.folder(id.Format());

        public FS.FolderPath Out(ProjectId id)
            => Home(id) + FS.folder(output);

        public FS.Files OutFiles(ProjectId id)
            => Out(id).Files(true);

        public FS.FolderPath Docs(ProjectId id)
            => Home(id) + FS.folder(docs);

        public FS.Files DocFiles(ProjectId id)
            => Docs(id).Files(true);

        public FS.FilePath Doc(ProjectId project, string fileid, FS.FileExt ext)
            => Docs(project) + FS.file(fileid, ext);

        public FS.FolderPath Logs(ProjectId id)
            => Home(id) + FS.folder(logs);

        public FS.Files LogFiles(ProjectId id)
            => Logs(id).Files(true);

        public FS.FilePath Log(ProjectId project, string fileid)
            => Logs(project) + FS.file(fileid, FS.Log);

        public FS.FolderPath Src(ProjectId id)
            => Home(id) + FS.folder(src);

        public FS.Files SrcFiles(ProjectId id)
            => Src(id).Files(true);

        public FS.FilePath Src(ProjectId project, string fileid, FS.FileExt ext)
            => Src(project) + FS.file(fileid,ext);

        public FS.FolderPath Assets(ProjectId id)
            => Home(id) + FS.folder(assets);

        public bool Settings(ProjectId id, out ProjectConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ProjectId id, in ProjectConfig src)
            => ConfigLookup[id] = src;

        [MethodImpl(Inline)]
        internal ProjectBase WithRoot(FS.FolderPath root)
        {
            Root = root;
            return this;
        }
    }
}