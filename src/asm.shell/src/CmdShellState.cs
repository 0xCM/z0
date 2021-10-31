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
    public class CmdShellState
    {
        FS.FolderPath _CurrentDir;

        ToolId _Tool;

        ProjectId _Project;

        FS.Files _Files;

        FS.FolderPath _DataSource;

        ApiPath _Api;

        Arrow<Subject> _Channel;

        IWorkspace _Workspace;

        protected DevWs Ws;

        protected IWfRuntime Wf;

        public void Init(IWfRuntime wf, DevWs ws)
        {
            Ws = ws;
            Wf = wf;
            _Workspace = ws;
            _CurrentDir = ws.Root;
        }

        [MethodImpl(Inline)]
        public Arrow<Subject> Channel()
            => _Channel;

        [MethodImpl(Inline)]
        public IWorkspace Workspace()
            => _Workspace;

        [MethodImpl(Inline)]
        public Outcome Workspace(string name)
            => Ws.Select(name, out _Workspace);

        public Arrow<Subject> Channel(Arrow<Subject> channel)
        {
            _Channel = channel;
            return Channel();
        }

        public Arrow<Subject> Channel(Subject src, Subject dst)
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
            => _CurrentDir;

        [MethodImpl(Inline)]
        public FS.FolderPath CurrentDir(FS.FolderPath value)
        {
            _CurrentDir = value;
            return CurrentDir();
        }

        [MethodImpl(Inline)]
        public FS.Files Files()
            => _Files;

        public FS.Files Files(FS.FileExt ext)
            => Files().Where(f => f.Is(ext));

        public FS.Files Files(FS.FileExt a, FS.FileExt b)
            => Files().Where(f => f.Is(a) || f.Is(b));

        public FS.Files Files(FS.FileExt a, FS.FileExt b, FS.FileExt c)
            => Files().Where(f => f.Is(a) || f.Is(b) || f.Is(c));

        public FS.Files Files(FS.FileExt a, FS.FileExt b, FS.FileExt c, FS.FileExt d)
            => Files().Where(f => f.Is(a) || f.Is(b) || f.Is(c) || f.Is(d));

        [MethodImpl(Inline)]
        public FS.Files Files(FS.Files src)
        {
            _Files = src;
            return Files();
        }

        public CmdShellState()
        {
            _CurrentDir = FS.FolderPath.Empty;
            _Tool = default;
            _DataSource = FS.FolderPath.Empty;
            _Files = array<FS.FilePath>();
            _Api = ApiPath.Empty;
            _Channel = (Subject.Empty,Subject.Empty);
        }
    }
}