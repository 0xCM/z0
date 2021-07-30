//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static WsNames;

    public sealed class DevWs : IWorkspace<DevWs>
    {
        [MethodImpl(Inline)]
        public static DevWs create(FS.FolderPath root)
            => new DevWs(root);

        FS.FolderPath _WsRoot;

        FS.FolderPath _OutRoot;

        [MethodImpl(Inline)]
        DevWs(FS.FolderPath root)
        {
            _WsRoot = root;
            _OutRoot = FS.dir("j:/ws/.out");
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => _WsRoot;
        }

        public AsmWs Asm()
            => AsmWs.create(_WsRoot + FS.folder(asm));

        public ToolWs Tools()
            => ToolWs.create(_WsRoot + FS.folder(tools));

        public IWorkspace Tables()
            => TableWs.create(_WsRoot + FS.folder(tables));

        public IWorkspace Control()
            => ControlWs.create(_WsRoot + FS.folder(control));

        public ProjectWs Projects()
            => ProjectWs.create(_WsRoot + FS.folder(projects), _OutRoot + FS.folder(projects));

        public IWorkspace Sources()
            => SourcesWs.create(_WsRoot + FS.folder(sources));

        public IWorkspace Logs()
            => LogWs.create(_WsRoot + FS.folder(logs));

        public IWorkspace Gen()
            => GenWs.create(_WsRoot + FS.folder(gen));

        public IWorkspace Output()
            => OutputWs.create(_OutRoot);

        public IWorkspace Imports()
            => ImportsWs.create(_WsRoot + FS.folder(imports));

        public string Format()
            => _WsRoot.Format();

        public override string ToString()
            => Format();
    }
}