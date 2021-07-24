//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiComplete]
    public class ShellState
    {
        FS.FolderPath _SrcDir;

        ToolId _Tool;

        ProjectId _Project;

        FS.Files _Files;

        FS.FilePath _DataSource;

        ApiPath _Api;

        DevWs _DevWs;

        public DevWs DevWs()
        {
            return _DevWs;
        }

        public DevWs DevWs(DevWs ws)
        {
            _DevWs = ws;
            return DevWs();
        }

        [MethodImpl(Inline)]
        public ApiPath Api()
            => _Api;

        [MethodImpl(Inline)]
        public ApiPath Api(ApiPath src)
        {
            _Api = src;
            return Api();
        }

        [MethodImpl(Inline)]
        public ToolId Tool()
            => _Tool;

        [MethodImpl(Inline)]
        public ToolId Tool(ToolId id)
        {
            _Tool = id;
            return Tool();
        }

        [MethodImpl(Inline)]
        public FS.FilePath DataSource()
            => _DataSource;

        [MethodImpl(Inline)]
        public FS.FilePath DataSource(FS.FilePath src)
        {
            _DataSource = src;
            return DataSource();
        }

        [MethodImpl(Inline)]
        public ProjectId Project()
            => _Project;

        [MethodImpl(Inline)]
        public ToolWs Tools()
            => DevWs().Tools();

        [MethodImpl(Inline)]
        public ProjectId Project(ProjectId id)
        {
            _Project = id;
            return Project();
        }

        [MethodImpl(Inline)]
        public ProjectWs Projects()
            => DevWs().Projects();

        [MethodImpl(Inline)]
        public FS.FolderPath SrcDir()
            => _SrcDir;

        [MethodImpl(Inline)]
        public FS.FolderPath OutDir()
            => DevWs().Output().Root;

        [MethodImpl(Inline)]
        public FS.FolderPath SrcDir(FS.FolderPath value)
        {
            _SrcDir = value;
            return SrcDir();
        }

        [MethodImpl(Inline)]
        public FS.Files Files()
            => _Files;

        [MethodImpl(Inline)]
        public FS.Files Files(FS.Files src)
        {
            _Files = src;
            return Files();
        }

        [MethodImpl(Inline)]
        public TableWs Tables()
            => DevWs().Tables();

        public ShellState()
        {
            _SrcDir = FS.FolderPath.Empty;
            _Tool = default;
            _DataSource = FS.FilePath.Empty;
            _Files = array<FS.FilePath>();
            _Api = ApiPath.Empty;
        }

        public FS.FolderPath ToolOutDir(ToolId tool)
            => DevWs().Output().Subdir(tool.Format());

        public FS.FolderPath OutDir(string id)
            => DevWs().Output().Subdir(id);
    }
}