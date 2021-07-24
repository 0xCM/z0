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

    public sealed class ToolWs : IWorkspace<ToolWs>
    {
        [MethodImpl(Inline)]
        public static ToolWs create(FS.FolderPath root)
            => new ToolWs(root);

        const string config = nameof(config);

        const string docs = nameof(docs);

        const string logs = nameof(logs);

        const string scripts = nameof(scripts);

        const string samples = nameof(samples);

        public FS.FolderPath Root {get; private set;}

        Dictionary<ToolId,ToolConfig> ConfigLookup;

        public ToolWs(FS.FolderPath root)
        {
            Root = root;
            ConfigLookup = dict<ToolId,ToolConfig>();
        }

        public FS.FolderPath Home(ToolId id)
            => Root + FS.folder(id.Format());

        public FS.FolderPath Docs(ToolId id)
            => Home(id) + FS.folder(docs);

        public FS.FolderPath Logs(ToolId id)
            => Home(id) + FS.folder(logs);

        public FS.FolderPath Scripts(ToolId id)
            => Home(id) + FS.folder(scripts);

        public FS.FolderPath Samples(ToolId id)
            => Home(id) + FS.folder(samples);

        public FS.FilePath Script(string id)
            => Root + FS.file(id,FS.Cmd);

        public FS.FilePath Script(ToolId tool, string id)
            => Scripts(tool) + FS.file(id,FS.Cmd);

        public FS.FilePath ConfigScript(ToolId id)
            => Home(id) + FS.file(config, FS.Cmd);

        public FS.FilePath ConfigLog(ToolId id)
            => Logs(id) + FS.file(config, FS.Log);

        public bool Settings(ToolId id, out ToolConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ToolId id, in ToolConfig src)
            => ConfigLookup[id] = src;

        public FS.FolderPath WsRoot()
        {
            return Root;
        }

        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            Root = src;
            return WsRoot();
        }
    }
}