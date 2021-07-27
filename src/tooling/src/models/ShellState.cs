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

        FS.FolderPath _DataSource;

        ApiPath _Api;

        DevWs Ws;

        Arrow<Scope> _Channel;

        DevWs DevWs()
        {
            return Ws;
        }

        public DevWs DevWs(DevWs ws)
        {
            Ws = ws;
            return DevWs();
        }

        [MethodImpl(Inline)]
        public Arrow<Scope> Channel()
            => _Channel;

        public Arrow<Scope> Channel(Arrow<Scope> channel)
        {
            _Channel = channel;
            return Channel();
        }

        public Arrow<Scope> Channel(Scope src, Scope dst)
        {
            _Channel = (src,dst);
            return Channel();
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
        public FS.FolderPath DataSource()
            => _DataSource;

        [MethodImpl(Inline)]
        public FS.FolderPath DataSource(FS.FolderPath dir)
        {
            _DataSource = dir;
            return DataSource();
        }

        [MethodImpl(Inline)]
        public ProjectId Project()
            => _Project;

        [MethodImpl(Inline)]
        public ProjectId Project(ProjectId id)
        {
            _Project = id;
            return Project();
        }

        [MethodImpl(Inline)]
        public FS.FolderPath CurrentDir()
            => _SrcDir;

        [MethodImpl(Inline)]
        public FS.FolderPath CurrentDir(FS.FolderPath value)
        {
            _SrcDir = value;
            return CurrentDir();
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

        public ShellState()
        {
            _SrcDir = FS.FolderPath.Empty;
            _Tool = default;
            _DataSource = FS.FolderPath.Empty;
            _Files = array<FS.FilePath>();
            _Api = ApiPath.Empty;
            _Channel = (Scope.Empty,Scope.Empty);
        }
    }
}